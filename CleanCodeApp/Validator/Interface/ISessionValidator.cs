using CleanCodeApp.Models;

namespace CleanCodeApp.Validator.Interface
{
    public interface ISessionValidator
    {
        public void VerifySessionRequirements(List<Session> sessions);
        public void VerifyApprovedSessions(List<Session> sessions);
        public void VerifySessionAmount(List<Session> sessions);
    }
}
