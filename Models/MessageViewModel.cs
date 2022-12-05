using System;

namespace Prothean_Chat_Relay.Models
{
    public class MessageViewModel
    {
        private int _id;

        private string _addedBy;

        private int _groupId;

        private string _messageText;

        private string _socketId;
        
        public int ID 
        {
            get { return _id; }
            set { _id = value; } 
        }

        public string AddedBy
        {
            get { return _addedBy; }
            set { _addedBy = value; } 
        }

        public int GroupId 
        {
            get { return _groupId; }
            set { _groupId = value; } 
        }

        public string SocketId
        {
            get { return _socketId; }
            set { _socketId = value; }
        }

        public string message
        {
            get { return _messageText; }
            set { _messageText = value; }
        }
    }
}