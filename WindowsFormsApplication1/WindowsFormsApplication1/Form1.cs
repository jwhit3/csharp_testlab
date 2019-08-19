using System;
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
    public partial class Form1 : Form
    {
        List<string> _items = new List<string>();
        public Form1()
        {
            InitializeComponent();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Projects\Passman\database\server.txt");
            foreach (string line in lines)
                _items.Add(line);
            //_items.Add("One");
            //_items.Add("Two");
            //_items.Add("Three");

            listBox1.DataSource = _items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add button Clicked
            MessageBox.Show("Adding server");
            _items.Add("New Item" + DateTime.Now.Second);
            this.Hide();
            AddServer f2 = new AddServer();
            f2.ShowDialog();
            listBox1.DataSource = null;
            listBox1.DataSource = _items;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            try
            {
                // Remove Items in the list
                _items.RemoveAt(selectedIndex);
            }
            catch
            {

            }
            listBox1.DataSource = null;
            listBox1.DataSource = _items;
        }
    }
}
