using TemplatePattern.Templates;

namespace TemplatePattern.Models
{
    public class CompanyClearance : ClearanceTemplate
    {
        protected override void ObtainClearance()
        {
            BackgroundCheck();
            ExaminingRequiredAuthorization();
            GrantingClearanceBasedOnAuthorization();
        }

        private void BackgroundCheck()
        {
            Console.WriteLine("Conducting background check ...");
        }

        private void ExaminingRequiredAuthorization()
        {
            Console.WriteLine("Examining required authorization ...");
        }

        private void GrantingClearanceBasedOnAuthorization()
        {
            Console.WriteLine("Granting clearance based on authorization ...");
        }
    }
}
