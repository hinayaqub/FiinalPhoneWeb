using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using miniphone.Models;
namespace miniphone.Controllers
{
    public class TreeController : Controller
    {
        // GET: Tree
        public ActionResult Index()
        {

            TreeEntities db = new TreeEntities();
            List<Tree> list = db.Trees.ToList();
            List<TreeViewModel> viewList = new List<TreeViewModel>();

            foreach (Tree s in list)
            {
                TreeViewModel obj = new TreeViewModel();
                obj.branches = s.branches;
                obj.leaves = s.leaves;
                obj.nodes = s.nodes; 
                viewList.Add(obj);
            }
            return View(viewList);
        }

        // GET: Tree/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tree/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Tree/Create
        [HttpPost]
        public ActionResult Create(TreeViewModel obj )
        {

            try
            {

                // TODO: Add insert logic here
                Tree t1 = new Tree();
                t1.leaves = obj.leaves;
                t1.nodes = obj.nodes;
                t1.branches = obj.branches;
                TreeEntities t2 = new TreeEntities();
                t2.Trees.Add(t1);
                t2.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tree/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tree/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tree/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tree/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
