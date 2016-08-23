using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FolderClassification
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
        string selected_path=" ";
        string destination_path = " ";
        IEnumerable<string> files;

        Dictionary<string,   string[]    > FileTypes=new Dictionary<string, string[]>();
        //        [FileType] [Extensions]

        string default_file_types = "{ \"Audio\":[\".mp3\",\".ogg\",\".wav\"],\"Image\":[\".bmp\",\".jpg\",\".png\"],\"Video\":[\".mp4\",\".wmv\",\".flv\"] }";

        public Form1()
        {
            InitializeComponent();

            setJsonFile(@"data/input.json");

            cboxAddItems(cboxFileType);
            cboxAddItems(cboxExtension);

            cboxFileType .SelectedIndex = 0;
            cboxExtension.SelectedIndex = 0;
            cboxExtension .Enabled = false;

            txtboxFileName.Enabled = false;

            rdbPerfect    .Enabled = false;
            rdbPartial    .Enabled = false;

            rdbFileTypeOption .CheckedChanged += rdbCheckChanged;
            rdbExtensionOption.CheckedChanged += rdbCheckChanged;
            rdbOther          .CheckedChanged += rdbCheckChanged;

            btnSearch.Click += selectedIndexChanged;


            btnDestinationFolder.Enabled = false;
            btnMove             .Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                selected_path = folderBrowser.SelectedPath;
                SelectedPathLabel.Text = selected_path;
            }
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                destination_path = folderBrowser.SelectedPath;
                lblDestinationPath.Text = destination_path;
                btnMove.Enabled = true;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                int cnt = 0;
                foreach(var f in files)
                {
                    FileInfo file = new FileInfo(f);
                    FileInfo target = new FileInfo(destination_path+"\\"+System.IO.Path.GetFileName(f));
                    if (target.Exists)
                    {
                        target.Delete();
                        continue;
                    }
                    file.MoveTo(target.FullName);
                    cnt++;
                }
                label2.Text = cnt+" out of "+lstSelectedFiles.Items.Count.ToString()+" files moved.";
            }
            catch { MessageBox.Show("Unable to locate the destination directory.", "Error"); }
        }

        private void chkboxFileName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxFileName.Checked)
            {
                rdbPerfect    .Enabled = true;
                rdbPartial    .Enabled = true;
                txtboxFileName.Enabled = true;
            }
            else
            {
                rdbPerfect    .Enabled = false;
                rdbPartial    .Enabled = false;
                txtboxFileName.Enabled = false;
            }
        }



        private void rdbCheckChanged(object sender,EventArgs e)
        {
            if      (rdbFileTypeOption .Checked)
            {
                cboxExtension.SelectedIndex = 0;
                cboxFileType .Enabled = true;
                cboxExtension.Enabled = false;
            }
            else if (rdbExtensionOption.Checked)
            {
                cboxFileType.SelectedIndex = 0;
                cboxFileType .Enabled = false;
                cboxExtension.Enabled = true;
            }
            else if (rdbOther          .Checked)
            {
                cboxFileType .SelectedIndex = 0;
                cboxExtension.SelectedIndex = 0;
                cboxFileType .Enabled = false;
                cboxExtension.Enabled = false;
            }
        }

        private void setJsonFile(string ar_file_name)
        {
            System.IO.StreamReader sr;
            string json_;

            //Jsonファイルの読み込みに失敗すれば，デフォルトの設定を使用する．
            //読み込んだJsonファイルの中身がおかしければ同様にデフォルトの設定を使用する．
            try { sr = new System.IO.StreamReader(ar_file_name, System.Text.Encoding.GetEncoding("shift_jis")); }
            catch
            {
                setFileTypes(default_file_types);
                MessageBox.Show("Unable to load the JSON file", "Error");
                return;
            }

            json_ = sr.ReadToEnd();
            sr.Close();

            try { setFileTypes(json_); }
            catch
            {
                MessageBox.Show("The JSON file is wrong.", "Error");
                setFileTypes(default_file_types);
            }
        }

        private void setFileTypes(string ar_str)
        {
            FileTypes = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(ar_str);
        }

        private void cboxAddItems(ComboBox ar_cbox)
        {
            if (ar_cbox == cboxFileType)
            {
                foreach (var a in FileTypes)
                {
                    string s = "";
                    foreach (var b in a.Value)
                    {
                        s += b;
                        if (b != a.Value.Last())
                            s += ", ";
                    }
                    try { ar_cbox.Items.Add(a.Key + "(" + s + ")"); }
                    catch { ar_cbox.Items.Add(a.Key); }
                }
            }

            else if (ar_cbox == cboxExtension)
            {
                foreach (var a in FileTypes)
                    foreach (var b in a.Value)
                        ar_cbox.Items.Add(b);
            }
        }
        private void selectedIndexChanged(object sender,EventArgs e)
        {
            var selected_extension = cboxExtension.SelectedItem.ToString();
            lstSelectedFiles.Items.Clear();

            if (selected_path != " " && (cboxFileType.SelectedItem.ToString()!="None"||selected_extension != "None"||rdbOther.Checked==true))
            {
                lblDestinationPath.Text = " ";
                try
                {
                    //日付によるフィルタリング機能も搭載したかったが，計算コストの都合上実装しなかった
                    //Directory.GetFilesよりもDirectory.EnumerateFilesのほうが高速
                    //フォルダ選択時にレコードを何かしらを配列に入れてもいいが，
                    //リストアップ，アクセスの際に結局GetFilesを回避した恩恵がなくなる？入れない方がよさそう
                    files = Directory.EnumerateFiles(selected_path);
                    if      (rdbFileTypeOption .Checked)
                        files = files.Where(filename => FileTypes[FileTypes.Keys.ElementAt(cboxFileType.SelectedIndex - 1)]
                                                  .Any(pattern => filename.ToLower().EndsWith(pattern)));
                    else if (rdbExtensionOption.Checked)
                        files = files.Where(filename => filename.ToLower().EndsWith(selected_extension));

                    if (chkboxFileName     .Checked && txtboxFileName.Text != "")
                    {
                        if      (rdbPerfect.Checked)
                            files = files.Where(filename => filename == (selected_path + "\\" + txtboxFileName.Text));
                        else if (rdbPartial.Checked)
                            files = files.Where(filename => filename.Contains(txtboxFileName.Text));
                    }

                    foreach (var f in files)
                    {
                        lstSelectedFiles.Items.Add(f);
                    }
                    if (lstSelectedFiles.Items.Count != 0) btnDestinationFolder.Enabled = true;
                    else                                   btnDestinationFolder.Enabled = false;
                }
                catch { MessageBox.Show("Unable to the locate directory .", "Error"); }
            }
        }
    }
}
