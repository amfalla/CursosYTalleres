using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClasesYTalleres.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Categories = new DropDown();
        }

        public string Keywords { get; set; }
        public DropDown Categories { get; set; }
    }
}