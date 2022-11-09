using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        DBStudentMgmtContext db = new DBStudentMgmtContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InsertTBLClassRoom()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertTBLClassRoom( TblclassRoom tBLClassRoom)
        {
            db.TblclassRoom.Add(tBLClassRoom);
            db.SaveChanges();
            return View();
        }

        public PartialViewResult PrintTBLClassRoom()
        {
            var listClassRoom = db.TblclassRoom.ToList();
            return PartialView(listClassRoom);
        }

        public ActionResult DeleteTBLClassRoom(int id)
        {
            try
            {
                var DeleteTBLClassRoom = db.TblclassRoom.Where(x => x.IdCr == id).FirstOrDefault();
                db.TblclassRoom.Remove(DeleteTBLClassRoom);
                db.SaveChanges();
                return RedirectToAction("PrintTBLClassRoom");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddTBLStudent(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddTBLStudent(Tblstudent tBLStudent, int id)
        {
            db.Tblstudent.Add(tBLStudent);
            db.SaveChanges();
            return View();
        }

        public ActionResult ListTBLStudent(int id)
        { 
            var listStudent = (from cr in db.TblclassRoom
                               from st in db.Tblstudent
                               where cr.IdCr == st.IdCr && id == st.IdCr
                               select st).ToList();
            return View(listStudent);
        }

        public ActionResult DeleteTBLStudent(int id)
        {
            try
            {
                var DeleteTBLStudent= db.Tblstudent.Where(x => x.IdSt == id).FirstOrDefault();
                db.Tblstudent.Remove(DeleteTBLStudent);
                db.SaveChanges();
                return RedirectToAction("PrintTBLClassRoom");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ShowAllTBLStudent()
        {
            var ShowAllstudent = db.Tblstudent.ToList();
            return View(ShowAllstudent);
        }

        public ActionResult OrderByAscId()
        {
            var OrderByAscId = db.Tblstudent.OrderBy(x => x.IdSt).ToList();
            return View(OrderByAscId);
        }

        public ActionResult OrderByDscId()
        {
            var OrderByDscId = db.Tblstudent.OrderByDescending(x => x.IdSt).ToList();
            return View(OrderByDscId);
        }

        [HttpPost]
        public ActionResult SearchByName(IFormCollection f)
        {
            string KeySearchName = f["SearchValue"].ToString();
            List<Tblstudent> ListSearch = db.Tblstudent.Where(x => x.NameSt.Contains(KeySearchName)).ToList(); 
            if(ListSearch.Count == 0)
            {
                ViewBag.Notification = "No result found!";
            }
            else 
            {
                ViewBag.Notification = "Found " + ListSearch.Count + " result";
            }
            return View(ListSearch.OrderBy(x => x.NameSt));
        }
    }
}
