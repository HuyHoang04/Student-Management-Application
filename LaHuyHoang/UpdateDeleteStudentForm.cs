using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaHuyHoang
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        STUDENT student = new STUDENT();

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            SqlCommand cmd = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
            DataTable table = student.getStudent(cmd);
            if(table.Rows.Count > 0) {
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    RadioButtonFemale.Checked = true;
                }
                else
                {
                    RadioButtonMale.Checked = true;
                }
                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                TextBoxAddress.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void EditBt_Click(object sender, EventArgs e)
        {

            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(TextBoxID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student Age must Be Between 10 and 100 year", "Invalid Bday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (student.editStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("Student Edited", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool verif()
            {
                if ((TextBoxFname.Text.Trim() == "")
                    || (TextBoxLname.Text.Trim() == "")
                    || (TextBoxAddress.Text.Trim() == "")
                    || (TextBoxPhone.Text.Trim() == "")
                    || (PictureBoxStudentImage.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


        }

        private void AddPicBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            {
                if ((opf.ShowDialog() == DialogResult.OK))
                {
                    PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
                }
            }
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if(TextBoxID.Text != "")
            {
                STUDENT student = new STUDENT();
                int id = Convert.ToInt32(TextBoxID.Text);
                student.deleteStudent(id);
                MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
