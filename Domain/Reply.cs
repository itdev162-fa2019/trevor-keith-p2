using System;

namespace Domain
{
    public class Reply
    {
        public int posterId { get; set; }

        public int replyId {get; set; }

        public string replyContent { get; set; }

        public DateTime creationDT { get; private set; }

        public Reply() {
            creationDT = DateTime.Now;

        }
        
    }
    
}