using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaHuyHoang
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cOUSEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm form = new StudentListForm();
            form.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm form = new UpdateDeleteStudentForm();
            form.Show();
        }
    }
}
