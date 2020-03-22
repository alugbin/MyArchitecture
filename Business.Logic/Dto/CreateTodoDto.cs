using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Logic.Dto
{
    public class CreateTodoDto
    {
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime CompletedAt
        {
            get; set;
        }
    }
}
