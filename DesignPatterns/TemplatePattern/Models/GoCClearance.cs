using TemplatePattern.Templates;

namespace TemplatePattern.Models
{
    public class GoCClearance : ClearanceTemplate
    {
        protected override void ObtainClearance()
        {
            ExamineCitizenStatus();
            ExamineImmigrationStatus();
            ExaminePreviousAffiliations();
        }

        private void ExamineCitizenStatus()
        {
            Console.WriteLine("Examining citizen status...");
        }

        private void ExamineImmigrationStatus()
        {
            Console.WriteLine("Examining Immigration status...");
        }

        private void ExaminePreviousAffiliations()
        {
            Console.WriteLine("Examining previous affiliations...");
        }
    }
}
