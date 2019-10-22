using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.Model
{
    public class TodoItemModel
    {
        public Guid Guid { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Text { get; set; }
        public bool Done { get; set; }
    }
}
