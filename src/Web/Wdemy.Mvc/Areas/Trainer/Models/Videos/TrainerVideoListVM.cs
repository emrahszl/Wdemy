﻿namespace Wdemy.Mvc.Areas.Trainer.Models.Videos
{
    public class TrainerVideoListVM
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public byte[] VideoData { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public Guid LessonId { get; set; }
    }
}