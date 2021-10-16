using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

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

        public string newTodoInputValue { get; set; }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        
        void AddTodoItem(object obj)
        {
            TodoItems.Add(new TodoItem(newTodoInputValue, false));
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);

        void RemoveTodoItem(object obj)
        {
            TodoItem todoItemBeingRemoved = obj as TodoItem;
            TodoItems.Remove(todoItemBeingRemoved);
        }
    }
}
