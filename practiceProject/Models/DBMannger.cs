using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace practiceProject.Models
{
    public class DBMannger
    {

        MySqlConnection conn = new MySqlConnection( WebConfigurationManager.ConnectionStrings["MySQL_DBconnect"].ConnectionString);

        public void AddUser(string userName, string password, string gender, DateTime birth_Day, string birth_Time, string email)
        {
            using (var db = new Model1()) {
                var userlist = new userlist {user_Name = userName,user_Password = password,gender=gender,birth_Day = birth_Day ,birth_Time = birth_Time,email = email};
                db.userlists.Add(userlist);
                db.SaveChanges();
            }
        }
       
        public List<userlist> SearchUser(string userName,int a) {
            using (var db = new Model1())
            {
                var query = from b in db.userlists
                            where b.user_Name == userName
                            select b;
                List<userlist> list = query.ToList();
                if (query != null)
                    return list;
                else
                    return null;
            }
            
        }
    }
}