﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTodo.Model
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title  { get; set; }
        public string Status { get; set; }
    }
}
