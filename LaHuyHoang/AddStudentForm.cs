using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaHuyHoang
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void UploadImageBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            {
                if ((opf.ShowDialog() == DialogResult.OK))
                {
                    ImageBox.Image = Image.FromFile(opf.FileName);
                }
            }
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBt_Click(object sender, EventArgs e)
        {

            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(IDBox.Text);
            string fname = FirstNameBox.Text;
            string lname = LastNameBox.Text;
            DateTime bdate = BirthdateTimePicker.Value;
            string phone = PhoneBox.Text;
            string adrs = AddressBox.Text;
            string gender = "Male";
            if (FemaleRadioBt.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = BirthdateTimePicker.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student Age must Be Between 10 and 100 year", "Invalid Bday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                ImageBox.Image.Save(pic, ImageBox.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool verif()
            {
                if ((FirstNameBox.Text.Trim() == "")
                    || (LastNameBox.Text.Trim() == "")
                    || (AddressBox.Text.Trim() == "")
                    || (PhoneBox.Text.Trim() == "")
                    || (ImageBox.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void BirthdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
