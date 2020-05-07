using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practiceProject.Controllers
{
    public class DefaultController : Controller
    {
        public Models.User user = new Models.User();
        public static Models.UserAction userAction = new Models.UserAction();

        // GET: Default
        public ActionResult Index()
        {

            if (System.Web.HttpContext.Current.Session["user_Name"] != null)
            {
                user.userName = System.Web.HttpContext.Current.Session["user_Name"].ToString();
                user.password = System.Web.HttpContext.Current.Session["user_Password"].ToString();
                user.gender = System.Web.HttpContext.Current.Session["user_Gender"].ToString();
                user.birth_Day = System.Web.HttpContext.Current.Session["user_BirthDay"].ToString();
                user.birth_Time = System.Web.HttpContext.Current.Session["user_BirthTime"].ToString();
                user.email = System.Web.HttpContext.Current.Session["user_email"].ToString();
                ViewBag.userName = user.userName;
            }
            
            userAction = new Models.UserAction(user);
            ViewBag.isLogin = userAction.isLogin();
            return View("index");
        }

        public ActionResult Login()
        {
            
            return View("Login");
        }
        public ActionResult Logout()
        {
            System.Web.HttpContext.Current.Session["user_Name"] = null;
            System.Web.HttpContext.Current.Session["user_Password"] = null;
            System.Web.HttpContext.Current.Session["user_Gender"] = null;
            System.Web.HttpContext.Current.Session["user_BirthDay"] = null;
            System.Web.HttpContext.Current.Session["user_BirthTime"] = null;
            System.Web.HttpContext.Current.Session["user_email"] = null;
            user = new Models.User();
            return Index();
        }
        [HttpPost]
        public ActionResult Login(string user_Name,string user_Password)
        {
            if (userAction.isUserNameExist(user_Name))
            {
                if (userAction.isPasswordCorrect(user_Name, user_Password))
                {
                    userAction.Login(user_Name, user_Password);
                    System.Web.HttpContext.Current.Session["user_Name"] = user_Name;
                    System.Web.HttpContext.Current.Session["user_Password"] = user_Password;
                    System.Web.HttpContext.Current.Session["user_Gender"] = userAction.getUser().gender;
                    System.Web.HttpContext.Current.Session["user_BirthDay"] = userAction.getUser().birth_Day.Substring(0,10);
                    System.Web.HttpContext.Current.Session["user_BirthTime"] = userAction.getUser().birth_Time;
                    System.Web.HttpContext.Current.Session["user_email"] = userAction.getUser().email;
                    return Index();
                }
                else
                {
                    TempData["message"] = "密碼錯誤";
                }
            }
            else
            {
                TempData["message"] = "無此使用者";
            }
            return View("Login");
        }
        [HttpPost]
        public ActionResult Registered(FormCollection userCollection)
        {
            for (int i = 0; i < userCollection.Count; i++) {
                if (userCollection[i] == "")
                    return Registered();
            }
            userAction.Register(userCollection["user_Name"], userCollection["user_Password"] , userCollection["gender"] , userCollection["birth_Day"], userCollection["birth_Time"] , userCollection["email"]);
            return View("Login");
        }
        public ActionResult Registered()
        {
            List<SelectListItem> genderSelect = new List<SelectListItem>();
            genderSelect.Add(new SelectListItem
            {
                Value = "female",Text = "女"
            });
            genderSelect.Add(new SelectListItem
            {
                Value = "male",
                Text = "男",
                Selected = true
            }) ;
            
            string[] time = new string[]{"子","丑","尹","卯","辰","巳","午","未","申","酉","戌","亥"};
            List<SelectListItem> timeSelect = new List<SelectListItem>();
            for (int i = 0; i < time.Length; i++)
            {
                timeSelect.Add(new SelectListItem
                {
                    Value=time[i],Text=time[i]
                });
            }
            ViewBag.timeSelect = timeSelect;
            ViewBag.GenderSelect = genderSelect;
            return View("Registered");
        }
        public ActionResult test()
        {
            return View();
        }
    }
}