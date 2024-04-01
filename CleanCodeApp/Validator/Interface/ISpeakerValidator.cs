using CleanCodeApp.Models;

namespace CleanCodeApp.Validator.Interface
{
    public interface ISpeakerValidator
    {
        public void CheckEligibility(Speaker speaker);
        public void CheckQualifications(Speaker speaker);
    }
}
