using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using JooleApp.Domain;

namespace JooleApp.UI.Models
{
    public class CategoryViewModel
    {
        [HiddenInput]
        public Int64 Id { get; set; }


        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}
