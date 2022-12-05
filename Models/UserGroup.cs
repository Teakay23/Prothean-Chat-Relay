using System;

namespace Prothean_Chat_Relay.Models
{
    public class UserGroup
    {
        private int _id;

        private string _userName;

        private int _groupId;

        public int ID 
        {
            get { return _id; }
            set { _id = value; } 
        }

        public string UserName 
        {
            get { return _userName; }
            set { _userName = value; } 
        }

        public int GroupId 
        {
            get { return _groupId; }
            set { _groupId = value; } 
        }
    }
}