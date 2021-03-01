using System;
using System.Collections.Generic;
using System.Text;

namespace MTArsheemahediShethwala
{

    public class User
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _username;

        public String Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private String _password;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //Non Parameterized constructor
        public User() { }

        public User(int Id, String Username, String Password)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
        }



    }
}
