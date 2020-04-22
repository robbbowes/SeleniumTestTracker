using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestTracker.Core
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Test> Tests { get; set; }
    }
}
