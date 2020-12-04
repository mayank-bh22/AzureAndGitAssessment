using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {
            List<Student> list = new List<Student>()
            {
                new Student{SId=1,SName="Sakshi",SDob=new DateTime(day:17,month:09,year:1998),SContact="7878968574"},
                new Student{SId=2,SName="Mayank",SDob=new DateTime(day:22,month:09,year:1997),SContact="7412589632"},
                new Student{SId=3,SName="Zoya",SDob=new DateTime(day:11,month:09,year:2000),SContact="9858745896"},
                new Student{SId=4,SName="Rahul",SDob=new DateTime(day:05,month:09,year:2002),SContact="9696857478"},
                new Student{SId=5,SName="Meera",SDob=new DateTime(day:06,month:09,year:1999),SContact="7896968574"},
            };
            int x = list.Count();
            ViewBag.Total = x;
            return View(list);
        }
    }
}
