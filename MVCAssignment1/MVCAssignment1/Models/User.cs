using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAssignment1.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public string Gender { get; set; }
        public int ID { get; set; }
    }

    public class UserModel
    {
        public static List<User> userList = new List<User>
        {
            new User {
                FirstName = "Harsh",
                LastName = "Gadani",
                University = "Salisbury University",
                Gender = "Male",
                ID = 1
            }
        };

        public UserModel()
        {

        }

        public void Update(User u)
        {
            User update = userList.Find(user => user.ID == u.ID);
            update.FirstName = u.FirstName;
            update.LastName = u.LastName;
            update.University = u.University;
            update.Gender = u.Gender;
        }

        

        public void Add(User u)
        {
            u.ID = userList.Count() + 1;
            userList.Add(u);
        }

        public List<User> GetList()
        {
            return userList;
        }

        public void Delete(int id)
        {
            userList.RemoveAll(u => u.ID == id);
        }

        public User GetUser(int id)
        {
            return userList.Find(u => u.ID == id);
        }        
    }
}