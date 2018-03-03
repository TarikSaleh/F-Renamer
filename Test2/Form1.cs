using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strsorc = TextBox1.Text;

            char[] array1 = new char[] { 'Ç', 'ç', 'Ö', 'ö', 'İ', 'ı', ' '};
            char[] array2 = new char[] { 'C', 'c', 'O', 'o', 'I', 'i', '-'};

            char[] charArrsorc = strsorc.ToArray();

            for (int ch = 0; ch < charArrsorc.Length; ch++)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (ch == i)
                        {
                            TextBox2.Text = TextBox1.Text.Replace(charArrsorc[ch], array2[j]);
                        } 
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strsorc = TextBox1.Text;
            string strdest = TextBox2.Text;
            try
            {
                FileInfo sourcefile = new FileInfo(strsorc);
                if (sourcefile.Exists)
                {
                    sourcefile.MoveTo(strdest);
                    Label3.Text = "File Renamed";
                }
                else
                {
                    Label3.Text = "File Not Found";
                }
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }
        }
    }
}