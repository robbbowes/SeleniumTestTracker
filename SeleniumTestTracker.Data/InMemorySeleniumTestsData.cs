using SeleniumTestTracker.Core;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumTestTracker.Data
{
    public class InMemorySeleniumTestsData : ISeleniumTestsData
    {
        public IEnumerable<Package> Packages { get; set; }
        public List<Test> Tests { get; set; }
        public InMemorySeleniumTestsData()
        {
            Packages = new List<Package>()
            {
                new Package 
                { 
                    Id = 1, Name = "CourseAdmin", Tests = new List<Test>()
                    {
                        new Test
                        {
                            Id = 11, Name = "LoginTest1", Package = "CourseAdmin", IsBroken = true, TimesBroken = 1, Breakages = new List<Breakage>()
                            {
                                new Breakage { Id = 34, Reason = "Timeout on line 34", Codeline = "14.4.1" }
                            }
                        },
                        new Test
                        {
                            Id = 13, Name = "LoginTest2", Package = "CourseAdmin", IsBroken = true, TimesBroken = 1, Breakages = new List<Breakage>()
                            {
                                new Breakage { Id = 14, Reason = "Timeout on line 38", Codeline = "14.4.1" }
                            }

                        }
                    }
                },
                new Package
                {
                    Id = 2, Name = "ContentAdmin", Tests = new List<Test>()
                    {
                        new Test
                        {
                            Id = 23, Name = "MediaCreate", Package = "ContentAdmin", IsBroken = true, TimesBroken = 1, Breakages = new List<Breakage>()
                            {
                                new Breakage { Id = 35, Reason = "Timeout on line 34", Codeline = "14.4.1" }
                            }
                        },
                        new Test
                        {
                            Id = 56, Name = "TestCreate", Package = "ContentAdmin", IsBroken = false, TimesBroken = 2, Breakages = new List<Breakage>()
                            {
                                new Breakage { Id = 4, Reason = "Timeout on line 38", Codeline = "14.4.1" },
                                new Breakage { Id = 16, Reason = "Timeout on line 3", Codeline = "14.4.1" }

                            }

                        }
                    }
                }

            };
        }

        public IEnumerable<Package> GetPackages()
        {
            return from p in Packages
                   orderby p.Name
                   select p;
        }

        public IEnumerable<Test> GetTests()
        {
            return Packages.SelectMany(p => p.Tests);
        }

        public IEnumerable<Test> GetFailingTests()
        {
           return Packages.SelectMany(p => p.Tests.Where(t => t.IsBroken)).Distinct();
        }
    }
}