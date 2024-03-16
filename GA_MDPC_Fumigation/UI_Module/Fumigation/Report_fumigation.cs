using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GA_MDPC_Fumigation.LINQ;

namespace GA_MDPC_Fumigation.UI_Module.Fumigation
{
    public partial class Report_fumigation : Form
    {
        public Report_fumigation()
        {
            InitializeComponent();
        }
        public string fc_no = "";

        private void Report_fumigation_Load(object sender, EventArgs e)
        {
            load_report();
        }
        void load_report()
        {
            Fumigation_print the_report = new Fumigation_print();
            the_report.do_fumigation_print(fc_no);


            the_report.CreateDocument();
            documentViewer1.DocumentSource = the_report;
        }

        
    }
}
