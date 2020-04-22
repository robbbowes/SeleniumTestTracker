using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestTracker.Core
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Package { get; set; }
        public bool IsBroken { get; set; }
        public int TimesBroken { get; set; }
        public IEnumerable<Breakage> Breakages  { get; set; }

    }
}
