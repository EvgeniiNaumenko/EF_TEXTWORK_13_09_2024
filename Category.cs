﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //--------------
        public ICollection<Transaction> Transactions { get; set; }
    }
}
