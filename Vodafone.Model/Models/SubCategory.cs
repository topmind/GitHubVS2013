using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vodafone.Model.Models
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }
        public string Name { get; set; }
        public string SubCategoryCode { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
