using SeleniumTestTracker.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestTracker.Data
{
    public interface ISeleniumTestsData
    {
        IEnumerable<Package> GetPackages();
        IEnumerable<Test> GetFailingTests();
        IEnumerable<Test> GetTests();
    }

}
 

