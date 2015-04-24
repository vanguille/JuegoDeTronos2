using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploVentanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Baratheon().ShowDialog();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            new Lannister().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Greyjoy().ShowDialog();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            new Targaryen().ShowDialog();
        }
      
    }
}
