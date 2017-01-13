using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stats = int.Parse(textBox1.Text);
            int pid = int.Parse(textBox2.Text);
            Int32 addr = Convert.ToInt32(textBox3.Text, 16);
            MemoryRead.Hack(stats, pid, addr);
        }
    }
}
