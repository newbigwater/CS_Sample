using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var result = 
                from n in numbers
                where n % 2 == 0
                orderby n
                select n;

            foreach (int n in result)
                Console.WriteLine($"짝수 : {n}");
            
            Class[] arrClass = 
            {
                new Class() { Name = "ABC", Score = new int[] { 100, 73, 45, 100 }},
                new Class() { Name = "DEF", Score = new int[] { 88, 100, 100, 98 }},
                new Class() { Name = "GHI", Score = new int[] { 100, 43, 100, 100 }},
                new Class() { Name = "JKL", Score = new int[] { 93, 100, 19, 100 }},
            };
            
            var classes =
                from c in arrClass
                    from s in c.Score
                    where s < 90
                select new { c.Name, Lowest = s };
            foreach (var clas in classes)
                Console.WriteLine($"{clas}");


            Profile[] arrProfile =
            {
                new Profile() {Name = "ABC", Height = 186},
                new Profile() {Name = "DEF", Height = 158},
                new Profile() {Name = "GHI", Height = 172},
                new Profile() {Name = "JKL", Height = 178},
                new Profile() {Name = "MNO", Height = 171}
            };

            var listProfile = from profile in arrProfile
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };
            foreach (var Group in listProfile)
            {
                Console.WriteLine($"-175cm 미만? : {Group.GroupKey}");
                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine($"{profile.Name}, {profile.Height}");
                }
            }


            Console.WriteLine("");
            Console.WriteLine("체이닝1");
            var listProfile2 = arrProfile.Where(item => item.Height < 175)
                .Select(item => item);
            foreach (var profile in listProfile2)
            {
                Console.WriteLine($"{profile.Name}, {profile.Height}");
            }
            Console.WriteLine("체이닝2");
            var listProfile3 = arrProfile.GroupBy(item => item.Height < 175)
                .Select(grp => new {grp.Key, grp});
            foreach (var Group in listProfile3)
            {
                Console.WriteLine($"-175cm 미만? : {Group.Key}");
                foreach (var profile in Group.grp)
                {
                    Console.WriteLine($"{profile.Name}, {profile.Height}");
                }
            }
        }
    }
}
