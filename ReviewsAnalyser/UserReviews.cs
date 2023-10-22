namespace ReviewsAnalyser
{
    public class UserReviews
    {
        public UserReviews() 
        {
            customizationCount = 0;
            scalabilityCount = 0;
            useCount = 0;
            deploymentCount = 0;
            integrationCount = 0;
            testingCount = 0;
        }
        public int customizationCount { get; set; }
        public int scalabilityCount { get; set; }
        public int useCount { get; set; }
        public int deploymentCount { get; set; }
        public int integrationCount { get; set; }
        public int testingCount { get; set; }
        public int supportDocumentationCount { get; set; }
        public double customizationPercent { get; set; }
        public double scalabilityPercent { get; set; }
        public double usePercent { get; set; }
        public double deploymentPercent { get; set; }
        public double integrationPercent { get; set; }
        public double testingPercent { get; set; }
        public double supportDocumentationPercent { get; set; }
    }
}
