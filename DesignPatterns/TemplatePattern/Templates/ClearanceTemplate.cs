namespace TemplatePattern.Templates
{
    public abstract class ClearanceTemplate
    {
        public void FullProcess()
        {
            RecordFingerPrints();
            ObtainClearance();
            ApproveClearance();
        }

        private void RecordFingerPrints()
        {
            Console.WriteLine("FingerPrints recorded.");
        }

        protected abstract void ObtainClearance();

        private void ApproveClearance()
        {
            Console.WriteLine("Clearance approved!");
        }
    }
}
