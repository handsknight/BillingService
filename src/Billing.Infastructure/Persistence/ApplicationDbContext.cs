using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Infastructure
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<APICallLogEntity> APICallLogs{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APICallLogEntity>().HasData(
                new APICallLogEntity() { Id = 1, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 2, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 3, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 4, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 5, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("03/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 6, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/02/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 7, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 8, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 9, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 10, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("12/02/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 11, APIServiceId = "SAPI09-0982", CustomerName = "INTERSWITCH", CallDate = Convert.ToDateTime("03/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 12, APIServiceId = "SAPI09-0982", CustomerName = "INTERSWITCH", CallDate = Convert.ToDateTime("01/02/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 13, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 14, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 15, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 16, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 17, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("03/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 18, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/02/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 19, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 20, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 21, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 22, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("12/02/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 23, APIServiceId = "SAPI09-0982", CustomerName = "INTERSWITCH", CallDate = Convert.ToDateTime("03/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 24, APIServiceId = "SAPI09-0982", CustomerName = "INTERSWITCH", CallDate = Convert.ToDateTime("01/02/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 25, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 26, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 27, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 28, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 29, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("03/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 30, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/02/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 31, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 32, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 33, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 34, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("12/02/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 35, APIServiceId = "SAPI09-0982", CustomerName = "INTERSWITCH", CallDate = Convert.ToDateTime("03/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 36, APIServiceId = "SAPI09-0982", CustomerName = "INTERSWITCH", CallDate = Convert.ToDateTime("01/02/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 37, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 38, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 39, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 40, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 41, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("03/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 42, APIServiceId = "SAPI09-0982", CustomerName = "MTN", CallDate = Convert.ToDateTime("01/02/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 43, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 44, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("01/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 45, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("02/01/2022"), CallThrough = true },
                new APICallLogEntity() { Id = 46, APIServiceId = "SAPI09-0982", CustomerName = "STANBIC", CallDate = Convert.ToDateTime("12/02/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 47, APIServiceId = "SAPI09-0982", CustomerName = "INTERSWITCH", CallDate = Convert.ToDateTime("03/01/2022"), CallThrough = false },
                new APICallLogEntity() { Id = 48, APIServiceId = "SAPI09-0982", CustomerName = "INTERSWITCH", CallDate = Convert.ToDateTime("01/02/2022"), CallThrough = true });
        }
    }
}
