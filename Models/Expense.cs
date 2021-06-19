using System.Collections.Generic;

namespace PrettyExpensesSplitter.Models
{
    public class Expense
    {
        public Product Product { get; set; }

        public decimal TotalCost { get; set; }
        
        public HashSet<Person> Persons { get; set; }
    }
}