using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWD_Final_Project
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            this.projectsChart.Series["Projects"].Points.AddXY("User", Login.user.Projects_Count);
            this.projectsChart.Series["Projects"].Points.AddXY("Total", Login.administrator.Projects_Count);
        }

        private void projectsChart_Click(object sender, EventArgs e)
        {

        }
    }
}
