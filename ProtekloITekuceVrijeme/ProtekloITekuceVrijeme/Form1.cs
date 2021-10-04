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
    public partial class Form1 : Form
    {
        List<Test> listaTest = new List<Test>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test(textBox1.Text);
            listaTest.Add(test);
            textBox2.Clear();
            //textBox2.AppendText(test.ToString());
            foreach ( Test tst in listaTest)
            {
                textBox2.AppendText(tst.ToString() + "\r\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

        }
    }
}
