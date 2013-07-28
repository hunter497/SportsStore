// WIP

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    public class SelectedCategoryViewModel
    {
        public IEnumerable<string> Categories { get; set; }
        public string SelectedCategory { get; set; }
    }
}