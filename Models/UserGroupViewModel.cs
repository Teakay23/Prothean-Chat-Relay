using System;
using Prothean_Chat_Relay.Models;

namespace Prothean_Chat_Relay.Models
{
    public class UserGroupViewModel
    {
        private string _userName;

        private int _groupId;

        private string _groupName;

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

        public string GroupName
        { 
            get { return _groupName; }
            set { _groupName = value; }
        }
    }
}