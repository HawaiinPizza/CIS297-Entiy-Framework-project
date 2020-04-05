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
    public partial class Form4 : Form
    {
        private CollegeEntities collegeEntities;
        public Form4()
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

        private void Form4_Enter(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.collegeDataSet.Student);
            // TODO: This line of code loads data into the 'collegeSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.collegeSet.Student);
            this.majorTableAdapter.Fill(this.collegeSet.Major);
            this.majorTableAdapter.Fill(this.collegeSet.Major);

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


        // From stuff onward is reproduacable code.
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string Change=dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int ID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var query = collegeEntities.Courses.Where(s => s.Id == ID);
            switch (e.ColumnIndex)
            {
                case 2:
                    query.FirstOrDefault().Department = Change;
                    break;
                case 1:
                    query.FirstOrDefault().Name = Change;
                    break;
                case 3:
                    query.FirstOrDefault().Credits = Int32.Parse(Change);
                    break;
                case 4:
                    query.FirstOrDefault().Number = Change;
                    break;
            }


            query.FirstOrDefault().Name = Change;
            collegeEntities.SaveChanges();

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int DeleteID = Int32.Parse(e.Row.Cells[0].Value.ToString());
            var query=collegeEntities.Courses.Where(s => s.Id == DeleteID);
            collegeEntities.Courses.Remove(query.FirstOrDefault());
            collegeEntities.SaveChanges();
            //MessageBox.Show(query.FirstOrDefault().Id.ToString());
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (
                textName.Text.Length == 0 ||
                textUniq.Text.Length == 0 ||
                textMaj.Text.Length == 0
                )
            {
                MessageBox.Show("One of the data fields is eMPTY");

            }
            else
            {
                //try {
                    Student temp = new Student()
                    {
                        Name = textName.Text,
                        Major = Int32.Parse(textMaj.Text),
                        UniqueID = Int32.Parse(textUniq.Text)

                    };
                    collegeEntities.Students.Add(temp);
                    collegeEntities.SaveChanges();
                    dataGridView1.DataSource = collegeEntities.Students.ToList();
                    dataGridView1.Refresh();
                //}
                //catch (Exception j)
                //{
                    //MessageBox.Show("You either have UniqueID as a string, or Major is non exisent. I cna't tell I'm a robot\n"+j.Message);
                //}
            }
        }

        private void goSection_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 temp = new Form2();
            temp.Show();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
