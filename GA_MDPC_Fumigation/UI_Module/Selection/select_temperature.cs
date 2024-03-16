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
    public partial class select_temperature : Form
    {
        public select_temperature()
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
        private void btn_new_Click(object sender, EventArgs e)
        {
            UI_Module.Basic.frm_temperature the_form = new UI_Module.Basic.frm_temperature();
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
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                this.gv_list.Focus();
            }
        }

        void search()
        {
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            List<Mst_TemperatureView> records = (from c in dc.Mst_TemperatureViews
                                                 where c.Active == true
                                                 && ((tb_search.Text == "") || (tb_search.Text != "" &&
                                                 (c.Temperature.Contains(tb_search.Text)
                                                 )))

                                          orderby c.Temperature
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
        private void select_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gc_list.RowCount > 0)
            {
                Mst_TemperatureView the_result = (Mst_TemperatureView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
                this.selected_value1 = the_result.TemperatureID;
                this.selected_text1 = the_result.Temperature;
                this.DialogResult = DialogResult.Yes;
            }
            else if (e.KeyCode == Keys.Down)
            {

            }
            else if (e.KeyCode == Keys.Up)
            {

            }
        }
        private void gv_list_DoubleClick(object sender, EventArgs e)
        {
            Mst_TemperatureView the_result = (Mst_TemperatureView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
            this.selected_value1 = the_result.TemperatureID;
            this.selected_text1 = the_result.Temperature;
            this.DialogResult = DialogResult.Yes;
            //do_load();
        }


        private void gv_list_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && gc_list.RowCount > 0)
            {

                Mst_TemperatureView the_result = (Mst_TemperatureView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
                this.selected_value1 = the_result.TemperatureID;
                this.selected_text1 = the_result.Temperature;
                this.DialogResult = DialogResult.Yes;
            }
        }





    }
}
