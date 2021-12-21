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

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            richTextBoxIspis.SaveFile(Environment.SpecialFolder.MyDocuments+);

        }

        private void buttonMapa_Click(object sender, EventArgs e)
        {
            string mapa = "TestRichText";
            if (!Directory.Exists(Environment.SpecialFolder.MyDocuments + mapa))
            {

                Directory.CreateDirectory(Environment.SpecialFolder.MyDocuments + mapa);
            }
        }
    }
}
