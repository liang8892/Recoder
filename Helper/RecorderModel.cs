using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Helper
{
    public class RecorderModel : DbContext
    {
        public DbSet<Record> Records { get; set; }
    }


    public class Record
    {
        public int RecordID { get; set; }
    }
}
