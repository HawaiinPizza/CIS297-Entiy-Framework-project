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
    public partial class Form10 : Form
    {
        private CollegeEntities collegeEntities;
        public Form10()
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

        private void Form10_Enter(object sender, EventArgs e)
        {
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeSet.Majors' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.collegeSet.Major);
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
            var query = collegeEntities.Majors.Where(s => s.Id == ID);


            query.FirstOrDefault().Name = Change;
            collegeEntities.SaveChanges();

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                int DeleteID = Int32.Parse(e.Row.Cells[0].Value.ToString());
                var query = collegeEntities.Majors.Where(s => s.Id == DeleteID);
                collegeEntities.Majors.Remove(query.FirstOrDefault());
                collegeEntities.SaveChanges();
            }
            catch (Exception j)
            {
                MessageBox.Show("This instructor is referenced somewhere else. You have to delete THAT before deleting this");
                e.Cancel = true;
                dataGridView1.AllowUserToDeleteRows = true;
            }
        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToDeleteRows = true;
            if(
                NameLabel.Text.Length==0  ||
                TypeLabel.Text.Length==0  
                )
            {
                MessageBox.Show("One of the data fields is eMPTY");

            }
            else
            {
            MessageBox.Show(dataGridView1.AllowUserToDeleteRows.ToString());
                Major temp = new Major()
                {
                    Name = NameLabel.Text,
                    Type=TypeLabel.Text

                };
                collegeEntities.Majors.Add(temp);
                collegeEntities.SaveChanges();
                dataGridView1.DataSource = collegeEntities.Majors.ToList();
                dataGridView1.Refresh();
            }
            dataGridView1.AllowUserToDeleteRows = true;
            MessageBox.Show(dataGridView1.AllowUserToDeleteRows.ToString());
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

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("DELTE");
        }

        private void button4_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
        }
    }
}
