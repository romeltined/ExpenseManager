using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
        public string Particular { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
    }
}
