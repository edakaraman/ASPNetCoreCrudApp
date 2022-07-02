using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _Db;
        public StudentController(StudentContext Db)
        {
            _Db = Db;
        }
        public IActionResult StudentList()
        {
            try
            {
                var stdList = from a in _Db.tbl_Student
                              join b in _Db.tbl_Class
                              on a.ClassID equals b.ID
                              into Dep
                              from b in Dep.DefaultIfEmpty()

                              select new Student
                              {
                                  ID=a.ID,
                                  Name=a.Name,
                                  StudentID=a.StudentID,
                                  ClassID = a.ClassID,
                                  Classes=b==null?"":b.Classes

                              };
                return View(stdList);
            }
            catch (Exception ex)
            {
                return View();

            }      
        }

        public IActionResult Create(Student obj)
        {
            loadDDL();
            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student obj)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if (obj.ID == 0)
                    {
                        _Db.tbl_Student.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }
                   
                    return RedirectToAction("StudentList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("StudentList");
            }
        }



        public async Task<IActionResult> DeleteStd(int id)
        {
            try
            {
                var std =await _Db.tbl_Student.FindAsync(id);
                if (std!=null)
                {
                    _Db.tbl_Student.Remove(std);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("StudentList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("StudentList");
            }
        }



        private void loadDDL()
        {
            try
            {
                List<StuClass> depList=new List<StuClass>();
                depList = _Db.tbl_Class.ToList();

                depList.Insert(0, new StuClass { ID = 0, Classes = "Choose" }); 
                ViewBag.DepList = depList;

            }
            catch (Exception ex)
            {

                
            }
        }
    }
}