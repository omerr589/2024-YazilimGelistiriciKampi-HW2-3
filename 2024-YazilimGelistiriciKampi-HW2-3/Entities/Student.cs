using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_YazilimGelistiriciKampi_HW2_3.Entities
{
    internal class Student : Users
    {
        public List<Course> EnrolledCourses { get; set; }
    }
}
