using System;

namespace Prothean_Chat_Relay.Models
{
    public class Group
    {
        private int _id;

        private string _groupName;

        public int ID 
        { 
            get { return _id; }
            set { _id = value; } 
        }

        public string GroupName
        { 
            get { return _groupName; }
            set { _groupName = value; } 
        }
    }
}