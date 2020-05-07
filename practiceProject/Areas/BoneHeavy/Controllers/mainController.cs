using practiceProject.Areas.BoneHeavy.Models;
using practiceProject.Controllers;
using practiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practiceProject.Areas.BoneHeavy.Controllers
{
    public class mainController : Controller
    {
        
        // GET: BoneHeavy/main
        public ActionResult Index()
        {
            User user = new User();
            BvCalculate bc = new BvCalculate();
            if (System.Web.HttpContext.Current.Session["user_Name"] != null)
            {
                user.userName = System.Web.HttpContext.Current.Session["user_Name"].ToString();
                user.password = System.Web.HttpContext.Current.Session["user_Password"].ToString();
                user.gender = System.Web.HttpContext.Current.Session["user_Gender"].ToString();
                user.birth_Day = System.Web.HttpContext.Current.Session["user_BirthDay"].ToString();
                user.birth_Time = System.Web.HttpContext.Current.Session["user_BirthTime"].ToString();
                user.email = System.Web.HttpContext.Current.Session["user_email"].ToString();
                ViewBag.userName = user.userName;
                ViewBag.birth_Day = user.birth_Day;
                ViewBag.birth_Time = user.birth_Time;
                double sum = bc.countWeight(Convert.ToDateTime(user.birth_Day).Year, Convert.ToDateTime(user.birth_Day).Month, Convert.ToDateTime(user.birth_Day).Day, user.birth_Time);
                ViewBag.weight = sum;
                ViewBag.comment = bc.comment(sum);
            }
            ViewBag.isLogin = DefaultController.userAction.isLogin();
            return View();
        }
    }
}