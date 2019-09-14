using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LactoBioticsSystem.Reservation_Management
{
    public partial class ReserveProductsForm : Form
    {
        public ReserveProductsForm()
        {
            InitializeComponent();
        }

        private void PicboxResPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
