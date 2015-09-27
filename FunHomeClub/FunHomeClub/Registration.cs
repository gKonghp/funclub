using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunHomeClub
{

    class Registration
    {
        public Student student { get; set; }
        public Course course { get; set; }
        public DateTime enrollDate { get; set; }

        public Registration(Student student, Course course, DateTime enrollDate)
        {
            this.student = student;
            this.course = course;
            this.enrollDate = enrollDate;
        }
    }
}
