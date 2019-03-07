using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2SQL
{
    public class T_User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string UserType { get; set; }

        public DateTime? CreateTime { get; set; }

        public bool? IsDelete { get; set; }

        public T_User()
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=======================Id:" + this.Id+ "=======================");
            sb.AppendLine("Name:" + this.Name);
            sb.AppendLine("Content:" + this.Content);
            sb.AppendLine("UserType:" + this.UserType);
            sb.AppendLine(string.Format("CreateTime:{0:yyyy-MM-dd HH:mm:ss fff}",this.CreateTime));
            sb.AppendLine("IsDelete:" + this.IsDelete);
            return sb.ToString();
        }
    }
}
