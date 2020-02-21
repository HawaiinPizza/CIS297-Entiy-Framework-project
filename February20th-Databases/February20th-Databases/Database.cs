using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February20th_Databases
{
    public class Database
    {
        public List<Course> Courses { get; set; }
        public List<Section> Sections { get; set; }
        public List<Instructor> Instructors { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public List<Section> sections { get; set; }
    }

    public class Section
    {
        public int Id { get; set; }
        public Course course { get; set; }

        public Instructor instructor { get; set; }
        public string Day { get; set; }
    }

    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Office { get; set; }

        public List<Section> sections { get; set; }

    }
}
