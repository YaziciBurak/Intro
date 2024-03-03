using Test1.DataAccess.Absctracts;
using Test1.DataAccess.Concrates;
using Test1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Business;

    public class CourseManager
  {
    //dependecy injection
    private readonly ICourseDal _courseDal;

    public CourseManager (ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
       //Business rules  
        return _courseDal.GetAll();
    }


  }
  

