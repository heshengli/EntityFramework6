using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2SQL
{
    public class TD_UserType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public int? SortId { get; set; }

        public bool? IsDelete { get; set; }
    }
}
