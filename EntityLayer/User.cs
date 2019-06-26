using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class User
    {
        private int userID;
        public int UserID  
        {
            get
            {
                return userID;  
            }
            set
            {
                userID = value;
            }
        }
        private string username;////////////////////////////////
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }

        }
        private string password;//////////////////////////////
        public  string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
