using DegreePlan.Models;
using System;
using System.Linq;

namespace DegreePlan.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any Degrees.
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                     new Degree{DegreeID = 1 , DegreeAbv = "ACS+2" , DegreeName = "MS ACS +2"},
                     new Degree{DegreeID = 2 , DegreeAbv = "ACS+DB" , DegreeName = "MS ACS+ DB"},
                     new Degree{DegreeID = 3 , DegreeAbv = "ACS+NF" , DegreeName = "MS ACS + NF"},
                     new Degree{DegreeID = 4 , DegreeAbv = "ACS" , DegreeName = "MS ACS"},
                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");
                foreach (DegreePlan d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }
            if (context.Credits.Any())
            {
                Console.WriteLine("Credits already exist.");
            }
            else
            {
                var credits = new Credit[]
                {
                     new Credit{CreditID = 460 , CreditAbv = "DB" , CreditName = "Databases" , IsSummer = 0, IsSpring = 1 , IsFall = 1},
                     new Credit{CreditID = 356 , CreditAbv = "NF" , CreditName = "Network Fundamentals" , IsSummer = 0, IsSpring = 1 , IsFall = 1},
                     new Credit {CreditID = 542, CreditAbv = "542", CreditName = "OOP with java", IsSummer = 0, IsSpring = 1, IsFall = 1 },
                     new Credit {CreditID = 563, CreditAbv = "563", CreditName = "Web apps", IsSummer = 0, IsSpring = 1, IsFall= 1 },
                     new Credit {CreditID = 560, CreditAbv = "560", CreditName = "Advanced Databses", IsSummer = 1, IsSpring = 1, IsFall= 1 },
                     new Credit {CreditID = 664, CreditAbv = "664 - UX", CreditName = "User Experience Design", IsSummer = 0, IsSpring = 1, IsFall= 1 },
                     new Credit {CreditID = 618, CreditAbv = "618 - PM", CreditName = "Project management", IsSummer = 1, IsSpring = 0, IsFall= 0 },
                     new Credit {CreditID = 555, CreditAbv = "555 - NS", CreditName = "Network Security", IsSummer = 0, IsSpring = 1, IsFall=1 },
                     new Credit {CreditID = 691, CreditAbv = "691 - GDP1", CreditName = "GDP1", IsSummer = 1, IsSpring = 1, IsFall=1 },
                     new Credit {CreditID = 692, CreditAbv = "692 - GDP2", CreditName = "GDP2", IsSummer = 0, IsSpring = 1, IsFall= 1 },
                     new Credit {CreditID = 64, CreditAbv = "Mobile", CreditName = "643 or 644 mobile", IsSummer = 0, IsSpring = 1, IsFall= 1 },
                     new Credit {CreditID = 10, CreditAbv = "E1", CreditName = "Elective1", IsSummer = 0, IsSpring = 1, IsFall= 1 },
                     new Credit {CreditID = 20, CreditAbv = "E2", CreditName = "Elective2", IsSummer = 0, IsSpring = 1, IsFall=1 }
                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");
                foreach (DegreePlan d in credits)
                {
                    context.Credits.Add(d);
                }
                context.SaveChanges();
            }
            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("DegreeCredits already exist.");
            }
            else
            {
                var degreecredits = new DegreeCredit[]
                {
                         new DegreeCredit{ DegreeCreditID =1 , DegreeID =1 , CreditID =460},
                         new DegreeCredit{ DegreeCreditID =2 , DegreeID =1 , CreditID =356},
                         new DegreeCredit{ DegreeCreditID =3 , DegreeID =1 , CreditID =542},
                         new DegreeCredit{ DegreeCreditID =4 , DegreeID =1 , CreditID =563},
                         new DegreeCredit{ DegreeCreditID =5 , DegreeID =1 , CreditID =560},
                         new DegreeCredit{ DegreeCreditID =6 , DegreeID =1 , CreditID =664},
                         new DegreeCredit{ DegreeCreditID =7 , DegreeID =1 , CreditID =618},
                         new DegreeCredit{ DegreeCreditID =8 , DegreeID =1 , CreditID =555},
                         new DegreeCredit{ DegreeCreditID =9 , DegreeID =1 , CreditID =691},
                         new DegreeCredit{ DegreeCreditID =10 , DegreeID =1 , CreditID =692},
                         new DegreeCredit{ DegreeCreditID =11 , DegreeID =1 , CreditID =64},
                         new DegreeCredit{ DegreeCreditID =12 , DegreeID =1 , CreditID =10},
                         new DegreeCredit{ DegreeCreditID =13 , DegreeID =1 , CreditID =20},
                         new DegreeCredit{ DegreeCreditID =14 , DegreeID =2 , CreditID =460},
                         new DegreeCredit{ DegreeCreditID =16 , DegreeID =2 , CreditID =542},
                         new DegreeCredit{ DegreeCreditID =17 , DegreeID =2 , CreditID =563},
                         new DegreeCredit{ DegreeCreditID =18 , DegreeID =2 , CreditID =560},
                         new DegreeCredit{ DegreeCreditID =19 , DegreeID =2 , CreditID =664},
                         new DegreeCredit{ DegreeCreditID =20 , DegreeID =2 , CreditID =618},
                         new DegreeCredit{ DegreeCreditID =21 , DegreeID =2 , CreditID =555},
                         new DegreeCredit{ DegreeCreditID =22 , DegreeID =2 , CreditID =691},
                         new DegreeCredit{ DegreeCreditID =23 , DegreeID =2 , CreditID =692},
                         new DegreeCredit{ DegreeCreditID =24 , DegreeID =2 , CreditID =64},
                         new DegreeCredit{ DegreeCreditID =25 , DegreeID =2 , CreditID =10},
                         new DegreeCredit{ DegreeCreditID =26 , DegreeID =2 , CreditID =20},
                         new DegreeCredit{ DegreeCreditID =15 , DegreeID =3 , CreditID =356},
                         new DegreeCredit{ DegreeCreditID =27 , DegreeID =3 , CreditID =542},
                         new DegreeCredit{ DegreeCreditID =28 , DegreeID =3 , CreditID =563},
                         new DegreeCredit{ DegreeCreditID =29 , DegreeID =3 , CreditID =560},
                         new DegreeCredit{ DegreeCreditID =30 , DegreeID =3 , CreditID =664},
                         new DegreeCredit{ DegreeCreditID =31 , DegreeID =3 , CreditID =618},
                         new DegreeCredit{ DegreeCreditID =32 , DegreeID =3 , CreditID =555},
                         new DegreeCredit{ DegreeCreditID =33 , DegreeID =3 , CreditID =691},
                         new DegreeCredit{ DegreeCreditID =34 , DegreeID =3 , CreditID =692},
                         new DegreeCredit{ DegreeCreditID =35 , DegreeID =3 , CreditID =64},
                         new DegreeCredit{ DegreeCreditID =36 , DegreeID =3 , CreditID =10},
                         new DegreeCredit{ DegreeCreditID =37 , DegreeID =3 , CreditID =20},
                         new DegreeCredit{ DegreeCreditID =38 , DegreeID =4 , CreditID =542},
                         new DegreeCredit{ DegreeCreditID =39 , DegreeID =4 , CreditID =563},
                         new DegreeCredit{ DegreeCreditID =40 , DegreeID =4 , CreditID =560},
                         new DegreeCredit{ DegreeCreditID =41 , DegreeID =4 , CreditID =664},
                         new DegreeCredit{ DegreeCreditID =42 , DegreeID =4 , CreditID =618},
                         new DegreeCredit{ DegreeCreditID =43 , DegreeID =4 , CreditID =555},
                         new DegreeCredit{ DegreeCreditID =44 , DegreeID =4 , CreditID =691},
                         new DegreeCredit{ DegreeCreditID =45 , DegreeID =4 , CreditID =692},
                         new DegreeCredit{ DegreeCreditID =46 , DegreeID =4 , CreditID =10},
                         new DegreeCredit{ DegreeCreditID =47 , DegreeID =5 , CreditID =64},
                         new DegreeCredit{ DegreeCreditID =48 , DegreeID =5 , CreditID =20},
                };

                Console.WriteLine($"Inserted {degreecredits.Length} new degree credits.");
                foreach (DegreePlan d in degreecredits)
                {
                    context.DegreeCredits.Add(d);
                }
                context.SaveChanges();
            }

        }

    }
}