using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtekloITekuceVrijeme
{
    public partial class Form2 : Form
    {

        List<Test> lista = new List<Test>();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Test> lista)
        {
            InitializeComponent();
        }

        internal List<Test> Lista { get => lista; set => lista = value; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
