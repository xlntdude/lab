using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Visitor_Menu : Form
    {
        public Visitor_Menu()
        {
            InitializeComponent();
        }

        private void Visitor_Click(object sender, EventArgs e)
        {
            Form adminForm = new Teams_main();
            adminForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form1();
            adminForm.Show();
        }
    }
}
