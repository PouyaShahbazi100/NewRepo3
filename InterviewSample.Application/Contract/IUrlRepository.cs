using InterviewSample.Models;

namespace InterviewSample.Application.Contract;

public interface IUrlRepository
{
    void Add(UrlInfo url);
    void Update(UrlInfo url);
    UrlInfo Get(string link);
}
