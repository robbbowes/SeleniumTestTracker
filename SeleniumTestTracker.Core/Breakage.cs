using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestTracker.Core
{
    public class Breakage
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public string Codeline { get; set; }
    }
}
