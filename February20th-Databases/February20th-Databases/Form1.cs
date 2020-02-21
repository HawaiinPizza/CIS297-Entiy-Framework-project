using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace February20th_Databases
{
    public partial class Form1 : Form
    {
        private List<Course> courses;
        public Form1()
        {
            InitializeComponent();
            courses = new List<Course>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Instructor eric = new Instructor
            {
                Id = 1,
                Name = "Eric Charnesky",
                Phone = "248-762-4206",
                Office = "CIS 237"
            };

            // slow way!
            eric.Id = 1;
            eric.Name = "Eric Charnesky";

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=College;Integrated Security=True";
            // thank you https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand?view=netframework-4.8


            string queryString =
                "SELECT Id, Department, Number, Name, Credits FROM Course;";

            // using let's us avoid having to dispose
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        label1.Text += (String.Format("{0} {1} {2} {3} {4}{5}",
                            reader[0], reader[1], reader[2], reader[3], reader[4], Environment.NewLine));
                        Course course = new Course()
                        {
                            Id = Convert.ToInt32(reader[0]),
                            Department = reader[1].ToString(),
                            Number = reader[2].ToString(),
                            Name = reader[3].ToString(),
                            Credits = Convert.ToInt32(reader[4])


                        };

                        courses.Add(course);

                    }
                }
                // thanks to using I don't have to call this - connection.Dispose();
            }
        }
    }
}
