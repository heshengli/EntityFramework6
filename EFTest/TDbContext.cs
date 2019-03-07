using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2SQL
{
    public class TDbContext:DbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="nameOrConnectionString">数据连接名称或者数据库连接</param>
        public TDbContext(string nameOrConnectionString):base(nameOrConnectionString)
        {

        }

        public TDbContext() : base("conn")
        {
            this.Database.Log = log;
            // 不用检测__MigrationHistory(移除检测)
            Database.SetInitializer<TDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<T_User> T_User { get; set; }

        public virtual DbSet<TD_UserType> TD_UserType { get; set; }


        public void log(string sql)
        {
            Console.WriteLine(sql);
        }
    }
}
