using InterviewSample.Models;
using Microsoft.EntityFrameworkCore;

namespace InterviewSample.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    public DbSet<UrlInfo> Urls { get; set; }
}
