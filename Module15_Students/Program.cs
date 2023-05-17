using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadLine();
        }

        static List<string> GetAllStudents(Classroom[] classes)
        {
            var temparr = classes.SelectMany(x => x.Students);
            List<string> AllStudents = classes.SelectMany(x => x.Students).ToList();
            //var AllStudents = new List<Classroom>();

            //string[] buses = string [0];
            //foreach (var theclass in classes)
            //{
            //    var AllStudents = theclass.Students.Union(AllStudents);
            //arr = theclass.Students.Union(arr);

            //}
            return AllStudents;
            
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
