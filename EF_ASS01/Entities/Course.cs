﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ASS01.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal duration {  get; set; }
        public string Description {  get; set; }
        public int TopId { get; set; }
    }
}
