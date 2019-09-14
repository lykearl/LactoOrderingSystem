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

namespace LactoBioticsSystem.Reports
{

    /// <summary>
    /// Interaction logic for SalesReportsForm.xaml
    /// </summary>
    public partial class SalesReportsForm : UserControl
    {
        class SalesReportViewModel
        {
            public List<SalesReport> SalesReports { get; set; }
        }
        public SalesReportsForm()
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var VM = new SalesReportViewModel { SalesReports = (from sp in db.SalesReports select sp).ToList() };
            InitializeComponent();
            this.DataContext = VM;
        }
        public void Print(FlowDocument fd)
        {
            var pd = new PrintDialog();
            if (pd.ShowDialog().Value)
            {
                IDocumentPaginatorSource document = fd as IDocumentPaginatorSource;
                try
                {
                    pd.PrintDocument(document.DocumentPaginator, "Printing FlowDocument.");
                    MessageBox.Show("Successfully printed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_print_click(object sender, RoutedEventArgs e)
        {
            Print(fd_document);
        }
    }
}
