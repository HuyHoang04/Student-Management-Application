using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaHuyHoang
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.myDBDataSet1.std);

            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudent(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void RefershBt_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudent(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.TextBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                updateDeleteStdF.RadioButtonFemale.Checked = true;
            }
            updateDeleteStdF.TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdF.TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.PictureBoxStudentImage.Image = Image.FromStream(picture);

            updateDeleteStdF.Show();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.TextBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString()=="Female"))
            {
                updateDeleteStdF.RadioButtonFemale.Checked = true;
            }
            else { updateDeleteStdF.RadioButtonMale.Checked = true; }
            updateDeleteStdF.TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdF.TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.PictureBoxStudentImage.Image = Image.FromStream(picture);

            updateDeleteStdF.Show();
        }
    }
}
