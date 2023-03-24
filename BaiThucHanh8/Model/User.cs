using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiThucHanh8
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public bool gender { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User(string firstName, string lastName, string email, bool gender, string address, string username, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.gender = gender;
            this.address = address;
            this.username = username;
            this.password = password;
        }
        public User()
        {
            this.firstName = "";
            this.lastName = "";
            this.email = "";
            this.gender = false;
            this.address = "";
            this.username = "";
            this.password = "";
        }
    }
}