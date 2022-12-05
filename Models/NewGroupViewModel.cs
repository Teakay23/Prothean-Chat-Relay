using System;
using System.Collections.Generic;

namespace Prothean_Chat_Relay.Models
{
    public class NewGroupViewModel
    {
        private string _groupName;

        public string GroupName 
        { 
            get { return _groupName; }
            set { _groupName = value; }
        }

        public List<string> UserNames { get; set; }
    }
}