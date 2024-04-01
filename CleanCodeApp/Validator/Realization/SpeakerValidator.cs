using CleanCodeApp.Enums;
using CleanCodeApp.Exceptions;
using CleanCodeApp.Models;
using CleanCodeApp.Service.Realization;
using CleanCodeApp.Validator.Interface;

namespace CleanCodeApp.Validator.Realization
{
    public class SpeakerValidator : ISpeakerValidator
    {
        private const int requiredCertifications = 3;
        private const int requiredYearsOfExperience = 10;
        private const int requiredBrowseVersion = 9;
        private readonly EmployerService _employerService = new EmployerService();
        private readonly DomainService _domainService = new DomainService();
        public void CheckEligibility(Speaker speaker)
        {
            if (string.IsNullOrWhiteSpace(speaker.FirstName)) throw new ArgumentNullException("First Name is required");
            if (string.IsNullOrWhiteSpace(speaker.LastName)) throw new ArgumentNullException("Last name is required.");
            if (string.IsNullOrWhiteSpace(speaker.Email)) throw new ArgumentNullException("Email is required.");
        }

        public void CheckQualifications(Speaker speaker)
        {
            if (!(VerifyTechnicalRequrements(speaker) && VerifyDomainRequirements(speaker)))
            {
                throw new SpeakerDoesntMeetRequirementsException("Speaker doesn't meet our abitrary and capricious standards.");
            }
        }

        public bool VerifyTechnicalRequrements(Speaker speaker)
        {
            return VerifyCertifications(speaker) || VerifyYearsOfExperience(speaker) || VerifyEmployer(speaker) || VerifyBlogPresence(speaker);
        }

        public bool VerifyCertifications(Speaker speaker)
        {
            bool hasRequiredCertifications = speaker.Certifications.Count() > requiredCertifications;
            return hasRequiredCertifications;
        }

        public bool VerifyYearsOfExperience(Speaker speaker)
        {
            bool hasRequiredCertifications = speaker.Experience > requiredYearsOfExperience;
            return hasRequiredCertifications;
        }

        public bool VerifyEmployer(Speaker speaker)
        {
            bool hasApprovedEmployer = _employerService.Contains(speaker.Employer);
            return hasApprovedEmployer;
        }

        public bool VerifyBlogPresence(Speaker speaker)
        {
            bool hasBlog = speaker.HasBlog;
            return hasBlog;
        }

        public bool VerifyDomainRequirements(Speaker speaker)
        {
            return VerifyDomain(speaker) && speaker.Browser.Name != BrowserName.InternetExplorer && speaker.Browser.MajorVersion >= requiredBrowseVersion;

        }

        public bool VerifyDomain(Speaker speaker)
        {
            string emailDomain = speaker.Email.Split('@').Last();
            bool containsDomain = !_domainService.Contains(emailDomain);
            return containsDomain;
        }
    }
}
