using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using WindowsFormsApp1;

namespace MahApps.Metro.Application2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            int stats = int.Parse(textBox1.Text);
            int pid = int.Parse(textBox2.Text);
            Int32 addr = Convert.ToInt32(textBox3.Text, 16);
            MemoryRead.Hack(stats, pid, addr);
        }
    }
}
