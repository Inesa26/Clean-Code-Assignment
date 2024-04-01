using CleanCodeApp.Models;
using CleanCodeApp.Repository.Realization;
using CleanCodeApp.Service.Interface;

namespace CleanCodeApp.Service.Realization
{
    public class EmployerService : IEmployerService
    {
        private readonly RepositoryImpl<Employer> _employerRepository;

        public EmployerService()
        {
            _employerRepository = new RepositoryImpl<Employer>(new List<Employer>
            {
                new Employer { Name = "Microsoft" },
                new Employer { Name = "Google" },
                new Employer { Name = "Fog Creek Software" },
                new Employer { Name = "37Signals" }
            });
        }

        public bool Contains(Employer employer)
        {
            return _employerRepository.Contains(employer);
        }
    }
}
