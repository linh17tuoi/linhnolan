﻿using BigSchool__lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool__lab456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}