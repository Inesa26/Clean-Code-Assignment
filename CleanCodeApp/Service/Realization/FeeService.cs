using CleanCodeApp.Service.Interface;

namespace CleanCodeApp.Service.Realization
{
    public class FeeService : IFeeService
    {
        public int CalculateRegistrationFee(int experience)
        {
            if (experience <= 1)
            {
                return 500;
            }
            else if (experience >= 2 && experience <= 3)
            {
                return 250;
            }
            else if (experience >= 4 && experience <= 5)
            {
                return 100;
            }
            else if (experience >= 6 && experience <= 9)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }
    }
}
