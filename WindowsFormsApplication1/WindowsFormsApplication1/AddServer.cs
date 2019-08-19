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

namespace WindowsFormsApplication1
{
    public partial class AddServer : Form
    {
        string server = null;
        string password = null;
        public AddServer()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            server = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Projects\\Passman\\database\\server.txt",append:true);
                sw.WriteLine(server + "," + password);
                sw.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            
        }

       
    }
}
