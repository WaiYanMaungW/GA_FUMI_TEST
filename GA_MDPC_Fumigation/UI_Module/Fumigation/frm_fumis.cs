using GA_MDPC_Fumigation.LINQ;
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
    public partial class frm_fumis : Form
    {
        public frm_fumis()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            do_new();
        }
        void do_new()
        {
            frm_fumi the_form = new frm_fumi();

            if (Program.get_show_window_status())
            {
                //the_form.WindowState = FormWindowState.Maximized;
                the_form.Show();
            }
            else
            {
               // the_form.WindowState = FormWindowState.Maximized;
                the_form.ShowDialog();
            }


            load_list();

        }
        void load_list()
        {
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            List<Mst_FumigationView> record = (from c in dc.Mst_FumigationViews
                                               where c.Active == true
                                         && (tb_search.Text == "" || tb_search.Text != "" &&
                                        (c.FCNO.Contains(tb_search.Text) ||
                                         c.SignatureName.Contains(tb_search.Text) ||
                                         c.PlaceOfLoading.Contains(tb_search.Text) ||
                                         c.CarrierName.Contains(tb_search.Text) ||
                                         c.DestinationName.Contains(tb_search.Text) ||
                                           c.ExporterName.Contains(tb_search.Text) ||
                                             c.ExporterAddress.Contains(tb_search.Text) ||
                                               c.ConsigneeName.Contains(tb_search.Text) ||
                                                 c.ConsigneeAddress.Contains(tb_search.Text) ||
                                         c.Remark.Contains(tb_search.Text)

                                         ))
                                         && ((dtp_from.Checked && dtp_to.Checked && c.CreatedOn.Date >= dtp_from.Value && c.CreatedOn.Date <= dtp_to.Value)
                                                 || (dtp_from.Checked && dtp_to.Checked == false && c.CreatedOn.Date == dtp_from.Value.Date)
                                                 || (dtp_from.Checked == false && dtp_to.Checked == false)
                                                 )
                                                 && ((dtp_fumigation.Checked && c.DateOfFumigation.Date == dtp_fumigation.Value.Date) || dtp_fumigation.Checked == false)
                                                  && ((dtp_issued.Checked && c.DateIssued.Date == dtp_issued.Value.Date) || dtp_issued.Checked == false)
                                               orderby c.FCNO
                                               select c
                                         ).ToList();
            gv_list.DataSource = record;

            gv_list.Refresh();
            gc_list.FocusedRowHandle = gc_list.RowCount - 1;
        }
        private void gv_list_DoubleClick(object sender, EventArgs e)
        {
            Mst_FumigationView the_result = (Mst_FumigationView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());

            if (the_result != null)
            {
                frm_fumi the_form = new frm_fumi();
                the_form.record_id = the_result.FumigationID;
                //if (the_form.ShowDialog() == DialogResult.Yes)
                the_form.ShowDialog();
                load_list();
            }
        }
        private void period_change(object sender, EventArgs e)
        {
            load_list();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            load_list();
        }

       

        private void frm_fumis_Load(object sender, EventArgs e)
        {
            load_list();
        }
    }
}
