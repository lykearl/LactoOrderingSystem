using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LactoBioticsSystem.Reports
{
    public partial class ViewSalesReport : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        class SalesReportViewModel
        {
            public List<SalesReport> SalesReports { get; set; }
            public User_acc User { get; set; } = ClsLogin.User;

            public DateTime Now{
                get { return DateTime.Now; }
                set { Now = value; }
            }

        }
        public ViewSalesReport(IQueryable<SalesReport> salesReport)
        {
            InitializeComponent();
            var VM = new SalesReportViewModel { SalesReports = salesReport.ToList() };
            salesReportsForm.DataContext = VM;
        }
        private void ViewSalesReport_Load(object senderz, EventArgs e)
        {
        }

        private void Btn_printSalesReport_Click(object sender, EventArgs e)
        {
            Print(salesReportsForm.fd_document);
        }
          public void Print(FlowDocument fd)
        {
            var pd = new System.Windows.Controls.PrintDialog();
            if (pd.ShowDialog().Value)
            {
                IDocumentPaginatorSource document = fd as IDocumentPaginatorSource;
                try
                {
                    pd.PrintDocument(document.DocumentPaginator, "Printing FlowDocument.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
