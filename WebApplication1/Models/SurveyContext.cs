using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
   public class SurveyContext: DbContext
    {
        public DbSet<Survey> Surveys { get; set; }

        public SurveyContext(DbContextOptions options) : base(options)
        {

        }
    }

}

