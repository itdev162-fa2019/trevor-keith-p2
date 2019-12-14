using System;
using System.Collections.Generic;

namespace Domain
{
    public class User
    {
        public string username { get; set; }

        public int userId { get; set; }

        public DateTime creationDate { get; set; }

        public User() {
            creationDate = DateTime.Now;

        }

    }

}