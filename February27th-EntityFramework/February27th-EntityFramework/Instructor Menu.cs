using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace February27th_EntityFramework
{
    public partial class Form1 : Form
    {
        private CollegeEntities collegeEntities;
        public Form1()
        {
            InitializeComponent();
            collegeEntities = new CollegeEntities();
        }




        private void courseNumberFilterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void facultyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSetInstructor.Instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.collegeDataSetInstructor.Instructor);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            MessageBox.Show(e.ToString());

        }


        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.instructorTableAdapter.FillBy(this.collegeDataSetInstructor.Instructor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        // From stuff onward is reproduacable code.
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string Change=dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int ID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var query = collegeEntities.Instructors.Where(s => s.Id == ID);


            switch (e.ColumnIndex)
            {
                case 1:
                    query.FirstOrDefault().Name = Change;
                    break;
                case 2:
                    query.FirstOrDefault().Phone = Change;
                    break;
                case 3:
                    query.FirstOrDefault().Office = Change;
                    break;
            }
            collegeEntities.SaveChanges();

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int DeleteID = Int32.Parse(e.Row.Cells[0].Value.ToString());
            var query=collegeEntities.Instructors.Where(s => s.Id == DeleteID);
            collegeEntities.Instructors.Remove(query.FirstOrDefault());
            collegeEntities.SaveChanges();
            //MessageBox.Show(query.FirstOrDefault().Id.ToString());
        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {
            if(
                NameLabel.Text.Length==0 || 
                OfficeLabel.Text.Length==0 || 
                PhoneLabel.Text.Length==0 
                )
            {
                MessageBox.Show("One of the data fields is eMPTY");

            }
            else
            {
                Instructor temp = new Instructor()
                {
                    Name = NameLabel.Text,
                    Office = OfficeLabel.Text,
                    Phone = PhoneLabel.Text,
                };
                collegeEntities.Instructors.Add(temp);
                collegeEntities.SaveChanges();
                dataGridView1.DataSource = collegeEntities.Instructors.ToList();
                dataGridView1.Refresh();
            }
        }

        private void goSection_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 temp = new Form2();
            temp.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 temp = new Form3();
            temp.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 temp = new Form5();
            temp.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 temp = new Form6();
            temp.Show();

        }
    }
}
