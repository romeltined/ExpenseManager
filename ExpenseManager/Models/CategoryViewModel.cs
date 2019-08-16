using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class CategoryViewModel
    {
        public CategoryEnum EnumCategory { get; set; }
    }

    public enum CategoryEnum
    {
        FoodGrocery,
        Clothing,
        Entertainment,
        Transportation,
        Remittance,
        Insurance,
        Dental,
        Travel,
        Electronics
    }
}

