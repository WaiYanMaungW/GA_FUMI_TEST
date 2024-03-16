using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_MDPC_Fumigation.UI_Module.Fumigation
{
    public partial class Report_fumigation2 : Form
    {
        public Report_fumigation2()
        {
            InitializeComponent();
        }
        public string fc_no = "";
        void load_report()
        {
            Fumigation_print2 the_report = new Fumigation_print2();
            the_report.do_fumigation_print(fc_no);


            the_report.CreateDocument();
            documentViewer1.DocumentSource = the_report;
        }

        private void Report_fumigation2_Load(object sender, EventArgs e)
        {
            load_report();

        }
    }
}
