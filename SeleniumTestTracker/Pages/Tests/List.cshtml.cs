using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeleniumTestTracker.Core;
using SeleniumTestTracker.Data;

namespace SeleniumTestTracker
{
    public class ListModel : PageModel
    {
        private readonly ISeleniumTestsData seleniumTestsData;
        public IEnumerable<Test> Tests { get; set; }
        public IEnumerable<Test> FailingTests { get; set; }

        public ListModel(ISeleniumTestsData seleniumTestsData)
        {
            this.seleniumTestsData = seleniumTestsData;
        }

        public void OnGet()
        {
            Tests = seleniumTestsData.GetTests();
            FailingTests = seleniumTestsData.GetFailingTests();
        }
    }
}