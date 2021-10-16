using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDoMobileApp
{
    public class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("Todo1", false));
            TodoItems.Add(new TodoItem("Todo2", false));
            TodoItems.Add(new TodoItem("Todo3", false));
        }
    }
}
