﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Etities
{
    public class SessionStudent
    {
        public int SessionId { get; set; }
        public Session Session { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
