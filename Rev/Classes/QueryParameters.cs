using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rev.Classes
{
    public class QueryParameters
    {
        public int Page { get; set; }
        public string SortBY { get; set; } = "Id";
        private string _sortOrder = "asc";
        public string sortOrder
        {
            get
            {
                return _sortOrder;
            }
            set
            {
                if(value == "asc" || value == "desc")
                {
                    _sortOrder = value;
                }
            }

        }
        
    }
}
