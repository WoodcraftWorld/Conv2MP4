using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conv2MP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.ShowDialog();
            saveFileDialog1.FileName = Path.GetFileName(openFileDialog1.FileName) + ".mp4";
            saveFileDialog1.ShowDialog();
            string strCmdText;
            strCmdText = "/C ffmpeg.exe -i \"" + openFileDialog1.FileName + "\" -c:v copy -c:a copy \"" + saveFileDialog1.FileName + "\" & pause & taskkill /f /im Conv2MP4.exe & exit";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            Thread.Sleep(90000);
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
