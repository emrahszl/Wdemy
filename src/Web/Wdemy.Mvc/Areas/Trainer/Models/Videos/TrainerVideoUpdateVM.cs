﻿namespace Wdemy.Mvc.Areas.Trainer.Models.Videos
{
    public class TrainerVideoUpdateVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? DocumentUri { get; set; }
        public IFormFile VideoData { get; set; } = null!;
    }
}
