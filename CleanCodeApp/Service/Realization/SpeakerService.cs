using CleanCodeApp.Models;
using CleanCodeApp.Repository.Interface;
using CleanCodeApp.Repository.Realization;
using CleanCodeApp.Service.Interface;
using CleanCodeApp.Validator.Interface;
using CleanCodeApp.Validator.Realization;

namespace CleanCodeApp.Service.Realization
{
    public class SpeakerService : ISpeakerService
    {
        private IRepository<Speaker> _speakerRepository;
        private ISpeakerValidator _speakerValidator;
        private ISessionValidator _sessionValidator;
        private IFeeService _feeService;

        public SpeakerService()
        {
            _speakerRepository = new RepositoryImpl<Speaker>();
            _speakerValidator = new SpeakerValidator();
            _sessionValidator = new SessionValidator();
            _feeService = new FeeService();
        }

        public Guid SaveSpeaker(Speaker speaker)
        {
            _speakerValidator.CheckEligibility(speaker);
            _speakerValidator.CheckQualifications(speaker);
            _sessionValidator.VerifySessionRequirements(speaker.Sessions);
            speaker.RegistrationFee = _feeService.CalculateRegistrationFee(speaker.Experience);
            return _speakerRepository.Add(speaker);

        }
    }
}
