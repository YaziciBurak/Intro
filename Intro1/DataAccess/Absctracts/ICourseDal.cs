using Intro1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro1.DataAccess.Absctracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add (Course course);
    }
}
