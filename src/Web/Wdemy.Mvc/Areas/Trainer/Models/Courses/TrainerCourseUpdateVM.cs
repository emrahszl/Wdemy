﻿using Wdemy.Domain.Entities;
using Wdemy.Mvc.Areas.Trainer.Models.Sections;

namespace Wdemy.Mvc.Areas.Trainer.Models.Courses
{
    public class TrainerCourseUpdateVM
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public List<TrainerSectionUpdateVM> Sections { get; set; } = null!;
    }
}
