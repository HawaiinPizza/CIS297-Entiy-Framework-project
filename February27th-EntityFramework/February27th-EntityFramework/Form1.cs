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
        CollegeEntities collegeEntities;
        public Form1()
        {
            InitializeComponent();
            collegeEntities = new CollegeEntities();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var College = new CollegeEntities();
            for(int i=0; i < dataGridView1.Rows.Count-1; i++)
            {
                if (0 > Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                {
                }
                else
                    MessageBox.Show("I can't even beat my dick");
            }
            College.SaveChanges();

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

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int DeleteID = Int32.Parse(e.Row.Cells[0].Value.ToString());
            var query=collegeEntities.Instructors.Where(s => s.Id == DeleteID);
            collegeEntities.Instructors.Remove(query.FirstOrDefault());
            collegeEntities.SaveChanges();
            //MessageBox.Show(query.FirstOrDefault().Id.ToString());

        }


        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString());

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("WOW");
        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            /*
                    Instructor newInstructor = new Instructor()
                    {
                        Id = Int32.Parse(e.Row.Cells[0].Value.ToString()),
                        Name = e.Row.Cells[1].Value.ToString(),
                        Phone = e.Row.Cells[2].Value.ToString(),
                        Office = e.Row.Cells[3].Value.ToString(),
                    }
                    ;
                    collegeEntities.Instructors.Add(newInstructor);
            collegeEntities.SaveChanges();
            */

        }

        private void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //MessageBox.Show("Complete");
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            //MessageBox.Show("CellNeeded");
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
    }
}
