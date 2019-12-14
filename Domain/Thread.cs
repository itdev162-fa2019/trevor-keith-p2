using System;

namespace Domain {
    public class Thread {
        public int posterId { get; set; }
        public int threadId {get; set; }
        public string threadTitle { get; set; }
        public string threadContent { get; set; }
        public DateTime creationDT { get; private set; }

        public Thread() {
            creationDT = DateTime.Now;

        }

    }
    
}