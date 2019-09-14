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
      
        public SalesReportsForm()
        {
            DatabaseDataContext db = new DatabaseDataContext();
            InitializeComponent();
        }
    }
}
