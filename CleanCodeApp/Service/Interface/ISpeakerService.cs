using CleanCodeApp.Models;

namespace CleanCodeApp.Service.Interface
{
    public interface ISpeakerService
    {
        Guid SaveSpeaker(Speaker speaker);
    }
}
