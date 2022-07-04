using System;

namespace FinalAssnment
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Patrick" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.Write("Addition Successful!");
                Console.ReadLine();
            }
        }
    }
}
