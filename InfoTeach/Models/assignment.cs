﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    [Table("Assignments")]
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        [ForeignKey("Lesson")]
        public int LessonId { get; set; }
        public string AssignmentName { get; set; }
        public Lesson Lesson { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
