using BLL.Implementations;
using BLL.Interfaces;
using DAL;
using DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University.Controllers
{
    public class GroupsController : Controller
    {
        public IGroupManager mngr;

        public GroupsController()
        {
            mngr = new GroupManager(new UnitOfWork());
        }
        // GET: Groups
        public ActionResult Index()
        {
            var groups = mngr.GetGroups();
            return View(groups);
        }

        [HttpGet]
        public ActionResult AddGroup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGroup(Groups group)
        {
            mngr.AddGroup(group);
            return RedirectToAction("Index");
        }
    }
}