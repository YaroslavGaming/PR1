using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR1.DBContext;

namespace PR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        model1 model1 = new model1();

        private void MainForm_load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model1.Users.ToList();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddUsers form = new FormAddUsers();
            form.ShowDialog();
            dataGridView1.DataSource = model1.Users.ToList();
        }
    }
}
