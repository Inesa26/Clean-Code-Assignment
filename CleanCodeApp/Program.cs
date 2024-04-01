using CleanCodeApp.Models;
using CleanCodeApp.Service.Realization;

namespace CleanCodeApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var speakerService = new SpeakerService();

            Speaker speaker = new Speaker
            {
                FirstName = "Inesa",
                LastName = "Godorozea",
                Email = "inesa@gmail.com",
                Experience = 0,
                HasBlog = true,
                BlogURL = "https://myblog.com",
                Browser = new WebBrowser("Chrome", 90),
                Certifications = new List<string> { "Certification1", "Certification2", "Certification3" },
                Employer = new Employer("Microsoft"),
                RegistrationFee = 0,
                Sessions = new List<Session> { new Session { Title = "Session Title", Description = "Session Description" } }
            };

            try
            {

                var speakerId = speakerService.SaveSpeaker(speaker);
                Console.WriteLine($"Speaker saved successfully with ID: {speakerId}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Failed to save speaker: {ex.Message}");
            }
        }
    }
}
