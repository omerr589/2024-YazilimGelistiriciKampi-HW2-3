using _2024_YazilimGelistiriciKampi_HW2_3.DataAccess.Abstracts;
using _2024_YazilimGelistiriciKampi_HW2_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_YazilimGelistiriciKampi_HW2_3.Business
{
    internal class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
    }
}
