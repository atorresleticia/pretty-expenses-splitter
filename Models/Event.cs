using System;
using System.Collections.Generic;

namespace PrettyExpensesSplitter.Models
{
    public class Event
    {
        public string Description { get; set; }
        
        public DateTime Date { get; set; }
        
        public List<Expense> Expenses { get; set; }
    }
}