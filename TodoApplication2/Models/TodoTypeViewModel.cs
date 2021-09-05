﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApplication2.Models
{
    public class TodoTypeViewModel
    {
        public List<Todo> Todos { get; set; }
        public SelectList Types { get; set; }
        public string TodoType { get; set; }
        public string SearchString { get; set; }
    }
}
