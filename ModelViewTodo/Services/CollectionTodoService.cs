﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;
using Newtonsoft.Json;
using Storm.Mvvm.Extensions;
using Storm.Mvvm.Inject;

namespace ModelViewTodo.Services
{
    public class CollectionTodoService : ICollectionTodoService
    {
        private ObservableCollection<Todo> _todoCollection;
        private int _count = 0;

        public ObservableCollection<Todo> GetCollection()
        {
            return _todoCollection ?? (_todoCollection = new ObservableCollection<Todo>());
        }

        public void AddCollec(string title, string description)
        {
            _todoCollection.Add(new Todo(title, description));
            _count++;
        }

        public void EditCollec(string title, string description, int index)
        {
            _todoCollection[index].Name = title;
            _todoCollection[index].Description = description;
        }

        public void SuppCollec(int i)
        {
            _todoCollection.Remove(_todoCollection[i]);
            _count--;
        }

        public async Task<bool> Refresh()
        {
            try
            {
                _todoCollection = new ObservableCollection<Todo>(await LazyResolver<IHttpService>.Service.GetTodoAsync());
                return true;
            }
            catch (JsonException)
            {
                return false;
            }
        }

    }
}