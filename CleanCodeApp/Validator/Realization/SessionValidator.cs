using CleanCodeApp.Exceptions;
using CleanCodeApp.Models;
using CleanCodeApp.Service.Realization;
using CleanCodeApp.Validator.Interface;

namespace CleanCodeApp.Validator.Realization
{
    public class SessionValidator : ISessionValidator
    {
        private readonly TechnologyService _technologyService = new TechnologyService();
        List<Technology> _technologyList = new List<Technology>();

        public void VerifySessionRequirements(List<Session> sessions)
        {
            VerifySessionAmount(sessions);

            _technologyList = _technologyService.GetAll();

            foreach (var session in sessions)
            {
                foreach (var technology in _technologyList)
                {

                    if (session.Title.Contains(technology.Name) || session.Description.Contains(technology.Name))
                    {
                        session.Approved = false;
                        break;
                    }
                    else
                    {
                        session.Approved = true;
                    }
                }
            }
            VerifyApprovedSessions(sessions);
        }

        public void VerifyApprovedSessions(List<Session> sessions)
        {
            bool atLeastOneApprovedSession = false;

            foreach (var session in sessions)
            {
                if (session.Approved)
                {
                    atLeastOneApprovedSession = true;
                    break;
                }
            }

            if (!atLeastOneApprovedSession)
            {
                throw new NoSessionsApprovedException("No sessions approved.");
            }
        }

        public void VerifySessionAmount(List<Session> sessions)
        {
            if (sessions.Count() == 0)
            {
                throw new ArgumentException("Can't register speaker with no sessions to present.");
            }
        }
    }
}
