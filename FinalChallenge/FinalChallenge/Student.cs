using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    public class Student: Microsoft.EntityFrameworkCore.DbContext
    {
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photos { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade? Grade { get; set; }

    }
}
