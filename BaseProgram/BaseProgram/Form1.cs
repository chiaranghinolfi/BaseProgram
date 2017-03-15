using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //{
            //    Madre m = new Madre("Claudia ", "Dalloli", "cdjkl330098t");
            //    listBox1 =m;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Madre m = new Madre("Claudia ", "Dalloli", "cdjkl330098t");
            //List<Madre> ml = new List<Madre>();
            //ml.Add( m);
            lista l = new lista();
            l.elenco.Add(m);


           listBox1.Items.Add(m.ToString());
        }
    }
}
