using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
    public class User
    {

        //private instance variables
        private int userId;
        private int sercuriteLevel;
        private string loginName;
        private string password;
        private string department;
        private string name;


        // public properties 

        public int EmployeeID
        {
            get { return userId; }
        }
        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int SecurityLevel
        {
            get { return sercuriteLevel; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public User(int userId)
        {
            if (userId == 1)
            {
                userId = 1;
                LoginName = "Donia";
                password = "da";
                Department = "IT";
                Name = "Donia Ahmad";
            }
            else if (userId == 2)
            {
                userId = 2;
                LoginName = "Jones";
                password = "mj";
                Department = "HR";
                Name = "Micheal Jones";
            }
            else
            {
                throw new Exception("Invalid EmployeeID");
            }

        }


        public void Login(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
            if (loginName == "Donia" & password == "da")
            {
                userId = 1;
                sercuriteLevel = 10;
            }
            else if (loginName == "Jones" & password == "mj")
            {
                userId = 2;
                sercuriteLevel = 4;
            }
            else
            {
                throw new Exception("Login incorrect.");
            }
        }
    }
}

