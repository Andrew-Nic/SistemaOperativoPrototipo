using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOperativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 frm2;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.inicio.Enabled = true;
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        int cont = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cont < 1 ){
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Form2();
            }
            frm2.Show();
                cont++;
            }
            else
            {
                frm2.Close();
                cont = 0;
            }
           

        }
       

    }
}
