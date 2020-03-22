using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Dtos
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; } 

        public DateTime CompletedAt  { get; set; }

        public static implicit operator TodoDto (Todo model)
        {
            return new TodoDto
            {
                Id = model.Id,
                CompletedAt = model.CompletedAt.ToLocalTime(),
                CreatedAt = model.CreatedAt.ToLocalTime(),
                Title = model.Title
            };
        }

    }
}
