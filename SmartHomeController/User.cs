using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    internal class User
    {
        private string username;
        private string contactinfo;
        private int userid;
        private string password;
        private bool isLoggedIn;

        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string ContactInfo
        {
            get { return contactinfo; }
            set { contactinfo = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }
        public bool Login(string username, string password)
        {
            if (Username == username && Password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine("Login successful.");
            }
            else
            {
                IsLoggedIn = false;
                Console.WriteLine("Login failed. Invalid username or password.");
            }
            return IsLoggedIn;
        }
        public void Logout()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("User logged out successfully.");
            }
            else
            {
                Console.WriteLine("User is not logged in.");
            }
        }
        public bool ControlDevice(int deviceId, string deviceName, string deviceAction)
                    {
            if (IsLoggedIn)
            {
                Console.WriteLine($"User {Username} is performing action '{deviceAction}' on device '{deviceName}' (ID: {deviceId}).");
                return true;
            }
            else
            {
                Console.WriteLine("Action failed. User is not logged in.");
                return false;
            }
        }
        public User(int userid, string username, string contactinfo, string password)
        {
            UserID = userid;
            Username = username;
            ContactInfo = contactinfo;
            Password = password;
            IsLoggedIn = false;
        }
    }
}
