using CleanCodeApp.Models;
using CleanCodeApp.Repository.Realization;
using CleanCodeApp.Service.Interface;

namespace CleanCodeApp.Service.Realization
{
    public class DomainService : IDomainService
    {
        private readonly RepositoryImpl<Domain> _domainRepository;


        public DomainService()
        {
            _domainRepository = new RepositoryImpl<Domain>(new List<Domain>
            {
                new Domain { Name = "aol.com" },
                new Domain { Name = "hotmail.com" },
                new Domain { Name = "hotmail.com" },
                new Domain { Name = "CompuServe.com" }
            });
        }
        public bool Contains(string emailDomain)
        {
            return _domainRepository.Contains(new Domain { Name = emailDomain });
        }
    }
}

