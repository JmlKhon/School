﻿namespace School.Models
{
    public abstract class BaseEntity
    {
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
