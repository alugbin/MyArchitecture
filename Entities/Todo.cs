﻿using System;

namespace Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime CompletedAt { get; set; }
        
    }
}
