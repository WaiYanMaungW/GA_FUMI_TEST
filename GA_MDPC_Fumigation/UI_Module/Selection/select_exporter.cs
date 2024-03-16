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

namespace GA_MDPC_Fumigation.UI_Module.Selection
{
    public partial class select_exporter : Form
    {
        public select_exporter()
        {
            InitializeComponent();
        }

        public string selected_value1 = "";
        public string selected_value2 = "";
        public string selected_value3 = "";
        public string selected_text1 = "";
        public string selected_text2 = "";
        public string selected_text3 = "";
        bool is_form_load = false;
        public bool only_show_parent = false;

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void gv_list_DoubleClick(object sender, EventArgs e)
        {
            Mst_Exporter_AddressView the_result = (Mst_Exporter_AddressView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
            this.selected_value1 = the_result.ExporterID;
            this.selected_text1 = the_result.ExporterName;
            this.selected_value2 = the_result.ExporterAddressID;
            this.selected_text2 = the_result.ExporterAddress;

            this.DialogResult = DialogResult.Yes;
            //do_load();
        }
        void search()
        {
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            List<Mst_Exporter_AddressView> records = (from c in dc.Mst_Exporter_AddressViews
                                                      where c.Active == true 
                                                 && ((tb_search.Text == "") || (tb_search.Text != "" &&
                                                 (c.ExporterName.Contains(tb_search.Text) ||
                                                 c.ExporterAddress.Contains(tb_search.Text)
                                                 )))

                                               orderby c.ExporterName,c.ExporterAddress
                                              select c).ToList();

            gv_list.DataSource = records;
            gv_list.Refresh();
        }

        private void select_form_Load(object sender, EventArgs e)
        {
            if (selected_text1 != "" && selected_value1 != "")
            {
                is_form_load = true;
                tb_search.Text = selected_text1;
                is_form_load = false;
            }
            search();
            tb_search.SelectAll();
            tb_search.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.selected_text1 = "";
            this.selected_value1 = "";
            this.DialogResult = DialogResult.Yes;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void gv_list_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && gc_list.RowCount > 0)
            {

                Mst_Exporter_AddressView the_result = (Mst_Exporter_AddressView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
                this.selected_value1 = the_result.ExporterID;
                this.selected_text1 = the_result.ExporterName;
                this.selected_value2 = the_result.ExporterAddressID;
                this.selected_text2 = the_result.ExporterAddress;
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void select_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gc_list.RowCount > 0)
            {
                Mst_Exporter_AddressView the_result = (Mst_Exporter_AddressView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
                this.selected_value1 = the_result.ExporterID;
                this.selected_text1 = the_result.ExporterName;
                this.selected_value2 = the_result.ExporterAddressID;
                this.selected_text2 = the_result.ExporterAddress;
                this.DialogResult = DialogResult.Yes;
            }
            else if (e.KeyCode == Keys.Down)
            {

            }
            else if (e.KeyCode == Keys.Up)
            {

            }
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                this.gv_list.Focus();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            UI_Module.Basic.frm_exporter the_form = new UI_Module.Basic.frm_exporter();
            the_form.WindowState = FormWindowState.Maximized;
            // the_form.FormBorderStyle = FormBorderStyle.None;
            the_form.AutoCloseAfterSave = true;
            if (the_form.ShowDialog() == DialogResult.Yes)
            {
                tb_search.Text = "";
                search();
                tb_search.Focus();
            }
        }
    }
}
