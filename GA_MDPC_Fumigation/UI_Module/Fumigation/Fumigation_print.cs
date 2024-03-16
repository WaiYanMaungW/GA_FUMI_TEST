using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace GA_MDPC_Fumigation.UI_Module.Fumigation
{
    public partial class Fumigation_print : DevExpress.XtraReports.UI.XtraReport
    {
        public Fumigation_print()
        {
            InitializeComponent();
        }
        public void do_fumigation_print(string fc_no)
        {
            Fc_no.Value = fc_no;
            sqlDataSource1.Fill();
        }

      
    }
}
