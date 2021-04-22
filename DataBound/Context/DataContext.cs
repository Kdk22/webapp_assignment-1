using System;
using DataBound.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBound.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)

        {


        }
        public DbSet<AuthorClass> Authors { get; set; }
        public DbSet<BlogClass> Blogs { get; set; }
    }
}
