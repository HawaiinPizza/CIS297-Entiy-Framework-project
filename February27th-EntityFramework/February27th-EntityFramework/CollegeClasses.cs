using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February27th_EntityFramework
{
    public partial class Course
    {
        public override string ToString()
        {
            return $"{Department} {Number}";
        }
    }
}
