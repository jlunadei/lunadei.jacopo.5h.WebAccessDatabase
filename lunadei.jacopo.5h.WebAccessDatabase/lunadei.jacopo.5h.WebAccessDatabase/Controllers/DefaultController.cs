using lunadei.jacopo._5h.WebAccessDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lunadei.jacopo._5h.WebAccessDatabase.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Query1(string Query, string SearchString2)
        {
            DAL dal = new DAL("PrenotazioniViaggi.accdb");
            DataTable table = dal.Getdata(Query);
            return View(table);

            //return View("~/Views/Default/Index.cshtml", table);
        }
    }
}