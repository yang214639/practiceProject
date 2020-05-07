using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace practiceProject.Models
{
    public class UserAction
    {
        protected User user;
        
        private DBMannger dBMannger;
        public UserAction(User user) {
            this.user = user;
            dBMannger = new DBMannger();
        }
        public UserAction()
        {
            dBMannger = new DBMannger();
        }
        public void setUser(User user)
        {
            this.user = user;
        }
        public User getUser()
        {
            return this.user;
        }
        public bool isLogin() {
            return user.userName!=null ? true:false ;
        }
        private List<userlist> dt= new List<userlist>();
        public bool isUserNameExist(string userName) {
             dt = dBMannger.SearchUser(userName,1);
            if (dt != null)
            {
                return true;
            }
            return false;
        }
        public bool isPasswordCorrect(string userName,string userPassword)
        {
            if (isUserNameExist(userName))
            {
                
                if(userPassword == dt[0].user_Password)
                {
                    return true;
                }
            }
            return false;
        }

        public void Login(string userName, string userPassword)
        {

            this.user.userName = dt[0].user_Name;
            this.user.password = dt[0].user_Password;
            this.user.gender = dt[0].gender;
            this.user.birth_Day = dt[0].birth_Day.ToString();
            this.user.birth_Time = dt[0].birth_Time;
            this.user.email = dt[0].email;
          
        }
        public void Register(string userName, string password, string gender, String birth_Day, string birth_Time, string email)
        {
            dBMannger.AddUser(userName,password, gender,Convert.ToDateTime(birth_Day),birth_Time, email);
        }
        public void Logout() {

        }
        
    }
}