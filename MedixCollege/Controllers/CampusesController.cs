﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class CampusesController : Controller
    {
        // GET: All Campuses
        public ActionResult Index()
        {
            ViewBag.HeroText = "";
            ViewBag.BodyHeaderText = "";
            ViewBag.SideHeader = "";
            ViewBag.SideSubHeader1 = "";
            ViewBag.SideSubText1 = "";
            ViewBag.SideSubHeader2 = "";
            ViewBag.SideSubText2 = "";
            ViewBag.SideSubHeader3 = "";
            ViewBag.SideSubText3 = "";

            return View();
        }

        // GET: Brampton
        public ActionResult Brampton()
        {
            return View();
        }

        // GET: Brantford
        public ActionResult Brantford()
        {
            return View();
        }

        // GET: Kitchener
        public ActionResult Kitchener()
        {
            return View();
        }

        // GET: London
        public ActionResult London()
        {
            return View();
        }

        // GET: Scarborough
        public ActionResult Scarborough()
        {
            return View();
        }

        // GET: Toronto
        public ActionResult Toronto()
        {
            return View();
        }
    }
}