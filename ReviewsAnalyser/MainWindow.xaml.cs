using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace ReviewsAnalyser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        private List<string> customizationKeywords = new List<string>
        {
            "UI", "UX", "styling", "customization", "collaboration tools", "version control", "product features",
            "features", "front-end", "back-end", "business logic", "workflow", "secure", "security", "services",
            "performance", "lock-in", "cloud", "flexibility", "time to market", "data modelling", "mobile app",
            "mobile", "governance", "quality", "agile", "collaboration", "design", "user interface", "report",
            "analytics", "dashboard", "reuse", "reusability", "intuitive", "architecture"
        };

        private List<string> integrationKeywords = new List<string>
        {
            "integration", "third-party", "third-party integration"
        };

        private List<string> testingKeywords = new List<string>
        {
            "testing", "test automation"
        };

        private List<string> deploymentKeywords = new List<string>
        {
            "deployment", "devops", "CI/CD", "migration"
        };

        private List<string> scalabilityKeywords = new List<string>
        {
            "scalability", "scalable", "large applications", "extensibility", "extensible"
        };

        private List<string> useKeywords = new List<string>
        {
            "fast development", "ease of development", "ease of use", "cost", "setup", "minimal coding", "ease of learning", 
            "easy to learn","citizen developers", "quick development", "large applications", "productivity", "productive", 
            "extensibility", "extensible", "end to end system"
        };

        private List<string> supportDocumentationKeywords = new List<string>
        {
            "documentation", "user support", "training", "user community", "accessibility", "community support", 
            "certifications", "tutorials"
        };

        private double totalReviews = 100;

        private UserReviews pReviews;
        public UserReviews positiveReviews
        {
            get
            {
                return pReviews;
            }
            set
            {
                pReviews = value;
            }
        }

        private UserReviews nReviews;
        public UserReviews negativeReviews
        {
            get
            {
                return nReviews;
            }
            set
            {
                nReviews = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            positiveReviews = new UserReviews();
            negativeReviews = new UserReviews();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //-- Reset previous data
            positiveReviews = new UserReviews();
            negativeReviews = new UserReviews();
            lblStatus.Content = "";

            //-- Open Excel file for reading
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            Microsoft.Office.Interop.Excel.Range rangeOfWorksheet;
            openFileDialog.DefaultExt = ".xlsx";
            bool? result = openFileDialog.ShowDialog();

            if (result != true) return;

            string workbookPath = openFileDialog.FileName;
            this.tbxFileName.Text = workbookPath;
            Application excelApp = new Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath);
            Worksheet? sheet = excelWorkbook.Sheets["Sheet1"] as Worksheet;
            if (sheet == null) return;
            rangeOfWorksheet = sheet.UsedRange;
            int columnsCount = rangeOfWorksheet.Columns.Count;

            /* Positive Reviews */
            Range positiveColumn = rangeOfWorksheet.Columns[2];
            foreach(Range row in positiveColumn.Rows)
            {
                if (!String.IsNullOrEmpty(row.Text))
                {
                    EvaluateKeywordsForPositiveReviews(row.Text);
                }
            }

            /* Negative Reviews */
            Range negativeColumn = rangeOfWorksheet.Columns[3];
            foreach (Range row in negativeColumn.Rows)
            {
                if (!String.IsNullOrEmpty(row.Text))
                {
                    EvaluateKeywordsForNegativeReviews(row.Text);
                }
            }

            DisplayResults();

            excelWorkbook.Close();
            excelApp.Quit();
            
            this.lblStatus.Content = "Analysis Completed!";
        }

        private void EvaluateKeywordsForPositiveReviews(string rowData)
        {
            if (customizationKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                positiveReviews.customizationCount++;
            }

            if (integrationKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                positiveReviews.integrationCount++;
            }

            if (testingKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                positiveReviews.testingCount++;
            }

            if (deploymentKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                positiveReviews.deploymentCount++;
            }

            if (scalabilityKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                positiveReviews.scalabilityCount++;
            }

            if (useKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                positiveReviews.useCount++;
            }

            if (supportDocumentationKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                positiveReviews.supportDocumentationCount++;
            }

            //--Calculate percentages
            positiveReviews.customizationPercent = (positiveReviews.customizationCount / totalReviews) * 100;
            positiveReviews.integrationPercent = (positiveReviews.integrationCount / totalReviews) * 100;
            positiveReviews.deploymentPercent = (positiveReviews.deploymentCount / totalReviews) * 100;
            positiveReviews.usePercent = (positiveReviews.useCount / totalReviews) * 100;
            positiveReviews.scalabilityPercent = (positiveReviews.scalabilityCount / totalReviews) * 100;
            positiveReviews.supportDocumentationPercent = (positiveReviews.supportDocumentationCount / totalReviews) * 100;
            positiveReviews.testingPercent = (positiveReviews.testingCount / totalReviews) * 100;
        }

        private void EvaluateKeywordsForNegativeReviews(string rowData)
        {
            if (customizationKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                negativeReviews.customizationCount++;
            }

            if (integrationKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                negativeReviews.integrationCount++;
            }

            if (testingKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                negativeReviews.testingCount++;
            }

            if (deploymentKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                negativeReviews.deploymentCount++;
            }

            if (scalabilityKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                negativeReviews.scalabilityCount++;
            }

            if (useKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                negativeReviews.useCount++;
            }

            if (supportDocumentationKeywords.Any(text => rowData.ToUpper().Contains(text.ToUpper())))
            {
                negativeReviews.supportDocumentationCount++;
            }

            //--Evaluate percentages
            negativeReviews.customizationPercent = (negativeReviews.customizationCount / totalReviews) * 100;
            negativeReviews.integrationPercent = (negativeReviews.integrationCount / totalReviews) * 100;
            negativeReviews.deploymentPercent = (negativeReviews.deploymentCount / totalReviews) * 100;
            negativeReviews.usePercent = (negativeReviews.useCount / totalReviews) * 100;
            negativeReviews.scalabilityPercent = (negativeReviews.scalabilityCount / totalReviews) * 100;
            negativeReviews.supportDocumentationPercent = (negativeReviews.supportDocumentationCount / totalReviews) * 100;
            negativeReviews.testingPercent = (negativeReviews.testingCount / totalReviews) * 100;
        }

        private void DisplayResults()
        {
            MessageBox.Show("POSITIVE REVIEWS" + "\n" + 
                "Customization percentage " + Math.Round(positiveReviews.customizationPercent,2).ToString() + "%" + "\n" +
                "Integration percentage " + Math.Round(positiveReviews.integrationPercent,2).ToString() + "%" + "\n" +
                "Scalability percentage " + Math.Round(positiveReviews.scalabilityPercent,2).ToString() + "%" + "\n" +
                "Testing percentage " + Math.Round(positiveReviews.testingPercent,2).ToString() + "%" + "\n" +
                "Use percentage " + Math.Round(positiveReviews.usePercent,2).ToString() + "%" + "\n" +
                "Deployment percentage " + Math.Round(positiveReviews.deploymentPercent,2).ToString() + "%" + "\n" +
                "Support and documentation percentage " + Math.Round(positiveReviews.supportDocumentationPercent,2).ToString() + "%" + "\n" +
                "***************************************************" + "\n" +
                "NEGATIVE REVIEWS" + "\n" +
                "Customization percentage " + Math.Round(negativeReviews.customizationPercent,2).ToString() + "%" + "\n" +
                "Integration percentage " + Math.Round(negativeReviews.integrationPercent,2).ToString() + "%" + "\n" +
                "Scalability percentage " + Math.Round(negativeReviews.scalabilityPercent,2).ToString() + "%" + "\n" +
                "Testing percentage " + Math.Round(negativeReviews.testingPercent,2).ToString() + "%" + "\n" +
                "Use percentage " + Math.Round(negativeReviews.usePercent,2).ToString() + "%" + "\n" +
                "Deployment percentage " + Math.Round(negativeReviews.deploymentPercent,2).ToString() + "%" + "\n" +
                "Support and documentation percentage " + Math.Round(negativeReviews.supportDocumentationPercent,2).ToString() + "%" + "\n");
        }
    }
}
