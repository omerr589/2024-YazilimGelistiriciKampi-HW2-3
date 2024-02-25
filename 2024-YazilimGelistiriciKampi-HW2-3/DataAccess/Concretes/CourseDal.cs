using _2024_YazilimGelistiriciKampi_HW2_3.DataAccess.Abstracts;
using _2024_YazilimGelistiriciKampi_HW2_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_YazilimGelistiriciKampi_HW2_3.DataAccess.Concretes
{
    internal class CourseDal : ICourseDal
    {

        public List<Course> GetAll()
        {
            // Bu alanda Db İşlemlerini Yapacağız Ancak Şimdilik El İle Veriler Girilecek
            return null;
        }
        
        public void Add(Course course)
        {

        }
    }
}
