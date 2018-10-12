using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL

{
    public enum Category
    {
        Commercial,
        Residential
    }
    static class CategoryChoice
    {
        public static Category category { get; private set; }

        public static Category GetCategory(string categorychoice)
        {

            if (categorychoice == Category.Commercial.ToString())
            {
                category = Category.Commercial;

            }
            if (categorychoice == Category.Residential.ToString())
            {
                category = Category.Residential;

            }

            return category;
        }

         
    }
}