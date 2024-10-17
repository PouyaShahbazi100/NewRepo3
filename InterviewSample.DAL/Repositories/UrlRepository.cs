using InterviewSample.Application.Contract;
using InterviewSample.Context;
using InterviewSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSample.DAL.Repositories;

public class UrlRepository(ApplicationDbContext dbContext) : IUrlRepository
{
    private readonly ApplicationDbContext dbContext = dbContext;

    public void Add(UrlInfo url)
    {
        dbContext.Add(url);
        dbContext.SaveChanges();
    }

    public UrlInfo Get(string link)
    {
        return dbContext.Urls.FirstOrDefault(u => u.Url == link);
    }

    public void Update(UrlInfo url)
    {
        dbContext.Update(url);
        dbContext.SaveChanges();
    }
}
