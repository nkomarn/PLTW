using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLTW1._5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseDoubleClick += new MouseEventHandler(pickPic);


        }
        Bitmap pic;
        System.IO.StreamReader sr;
        public void pickPic(Object sender, MouseEventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                try
                {
                    pic = new Bitmap(openFileDialog1.FileName, true);
                    pictureBox1.Image = pic;
                }
                catch (Exception)
                {

                    MessageBox.Show("The file you chose was not an image!");

                }
                
                sr.Close();
            }

            
        }
    }
}
