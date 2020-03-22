using DataAccess.BusinessDataAccess.Interface;
using DataAccess.Dtos;
using DataAccess.EFCore;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.BusinessDataAccess
{
    public class TodoDataProvider : ITodoDataProvider
    {
        private readonly BusinessDbContext context;

        public TodoDataProvider(BusinessDbContext _context)
        {
            context = _context;
        }

        public bool AddTodo(TodoDto todo)
        {
            var newTodo = new Todo
            {
                CreatedAt = todo.CreatedAt,
                CompletedAt = todo.CompletedAt,
                Title = todo.Title
            };
            context.Todos.Add(newTodo);
            return true;
        }

        public List<TodoDto> GetAllTodoItemsByDuration(DateTime fromDate)
        {
            return context.Todos.Where(c => c.CreatedAt >= fromDate && c.CreatedAt <= DateTime.UtcNow).Select(c => (TodoDto) c).ToList();
        }

    }
}
