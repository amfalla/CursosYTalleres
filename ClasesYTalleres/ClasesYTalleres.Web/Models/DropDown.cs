﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClasesYTalleres.Models
{
    [Bind(Include = "SelectedValue")]
    public class DropDown
    {   
        public string SelectedValue { get; set; }
        public SelectList DropDownList { get; set; }
    }
}