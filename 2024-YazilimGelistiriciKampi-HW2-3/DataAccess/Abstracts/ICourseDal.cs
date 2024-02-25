using _2024_YazilimGelistiriciKampi_HW2_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_YazilimGelistiriciKampi_HW2_3.DataAccess.Abstracts
{
    internal interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
    }
}
