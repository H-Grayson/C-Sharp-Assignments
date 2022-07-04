using System;
using System.Data.Entity;



namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new SchoolContext())
            { 
                var stud = new Student() { StudentName = "Hunter" };

                db.Students.Add(stud);
                db.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
