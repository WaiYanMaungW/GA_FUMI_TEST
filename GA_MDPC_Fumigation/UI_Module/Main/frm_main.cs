using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;
//apply raster skin
//UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2016Colorful);
//apply vector skin and choose a palette
//UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier, SkinSvgPalette.Bezier.CherryInk);
//disable skinning, apply the "Flat" style
//note that several DevExpress controls (for example, the Ribbon) cannot be displayed without a skin
//UserLookAndFeel.Default.SetStyle(LookAndFeelStyle.Flat, false, true);

namespace GA_MDPC_Fumigation.UI_Module.Main
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_main()
        {
            InitializeComponent();
        }


        UI_Module.Basic.frm_exporter _frm_exporter;
        private void btn_exporter_ItemClick(object sender, ItemClickEventArgs e)
        {
                if (_frm_exporter == null || _frm_exporter.IsDisposed)
                _frm_exporter = new UI_Module.Basic.frm_exporter ();
            _frm_exporter.WindowState = FormWindowState.Maximized;
            _frm_exporter.MdiParent = this;
            _frm_exporter.Show();
            
        }

        UI_Module.Basic.frm_consignee _frm_consignee;
        private void btn_consignee_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_consignee == null || _frm_consignee.IsDisposed)
                _frm_consignee = new UI_Module.Basic.frm_consignee();
            _frm_consignee.WindowState = FormWindowState.Maximized;
            _frm_consignee.MdiParent = this;
            _frm_consignee.Show();
        }

        UI_Module.Basic.frm_unit _frm_unit;
        private void btn_units_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_unit == null || _frm_unit.IsDisposed)
                _frm_unit = new UI_Module.Basic.frm_unit();
            _frm_unit.WindowState = FormWindowState.Maximized;
            _frm_unit.MdiParent = this;
            _frm_unit.Show();

        }
        UI_Module.Basic.frm_place_of_loading _frm_place_of_loading;
        private void btn_place_of_loading_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_place_of_loading == null || _frm_place_of_loading.IsDisposed)
                _frm_place_of_loading = new UI_Module.Basic.frm_place_of_loading();
            _frm_place_of_loading.WindowState = FormWindowState.Maximized;
            _frm_place_of_loading.MdiParent = this;
            _frm_place_of_loading.Show();
        }
        UI_Module.Basic.frm_conveyance _frm_conveyance;
        private void btn_conveyance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_conveyance == null || _frm_conveyance.IsDisposed)
                _frm_conveyance = new UI_Module.Basic.frm_conveyance();
            _frm_conveyance.WindowState = FormWindowState.Maximized;
            _frm_conveyance.MdiParent = this;
            _frm_conveyance.Show();

        }
        UI_Module.Basic.frm_destination _frm_destination;
        private void btn_destination_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_destination == null || _frm_destination.IsDisposed)
                _frm_destination = new UI_Module.Basic.frm_destination ();
            _frm_destination.WindowState = FormWindowState.Maximized;
            _frm_destination.MdiParent = this;
            _frm_destination.Show();
        }
        UI_Module.Basic.frm_chemical _frm_chemical;
        private void btn_chemical_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_chemical == null || _frm_chemical.IsDisposed)
                _frm_chemical = new UI_Module.Basic.frm_chemical();
            _frm_chemical.WindowState = FormWindowState.Maximized;
            _frm_chemical.MdiParent = this;
            _frm_chemical.Show();

        }
        UI_Module.Basic.frm_exposure_period _frm_exposure_period;
        private void btn_exposure_period_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_exposure_period == null || _frm_exposure_period.IsDisposed)
                _frm_exposure_period = new UI_Module.Basic.frm_exposure_period();
            _frm_exposure_period.WindowState = FormWindowState.Maximized;
            _frm_exposure_period.MdiParent = this;
            _frm_exposure_period.Show();

        }
        UI_Module.Basic.frm_concentration _frm_concentration;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_concentration == null || _frm_concentration.IsDisposed)
                _frm_concentration = new UI_Module.Basic.frm_concentration();
            _frm_concentration.WindowState = FormWindowState.Maximized;
            _frm_concentration.MdiParent = this;
            _frm_concentration.Show();
        }
        UI_Module.Basic.frm_temperature _frm_temperature;
        private void btn_temperature_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_temperature == null || _frm_temperature.IsDisposed)
                _frm_temperature = new UI_Module.Basic.frm_temperature();
            _frm_temperature.WindowState = FormWindowState.Maximized;
            _frm_temperature.MdiParent = this;
            _frm_temperature.Show();
        }
        UI_Module.System_Main.frm_password_change _frm_password_change = new UI_Module.System_Main.frm_password_change();

        private void btn_password_change_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_password_change == null || _frm_password_change.IsDisposed)
                _frm_password_change = new UI_Module.System_Main.frm_password_change();
            // _frm_password_change.WindowState = FormWindowState.Maximized;
            // _frm_password_change.MdiParent = this;
            if (_frm_password_change.ShowDialog() == DialogResult.Yes) { }
            else this.Close();

        }
        UI_Module.Fumigation.frm_fumigation_certificates _frm_fumigation_certifactes;
        private void btn_fumigation_certificate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_fumigation_certifactes == null || _frm_fumigation_certifactes.IsDisposed)
                _frm_fumigation_certifactes = new UI_Module.Fumigation.frm_fumigation_certificates();
            _frm_fumigation_certifactes.WindowState = FormWindowState.Maximized;
            _frm_fumigation_certifactes.MdiParent = this;
            _frm_fumigation_certifactes.Show();
        }
        UI_Module.Basic.frm_authorized_signature _frm_authorized_signature;
        private void btn_authorized_signature_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_authorized_signature == null || _frm_authorized_signature.IsDisposed)
                _frm_authorized_signature = new UI_Module.Basic.frm_authorized_signature();
            _frm_authorized_signature.WindowState = FormWindowState.Maximized;
            _frm_authorized_signature.MdiParent = this;
            _frm_authorized_signature.Show();
        }
        UI_Module.Fumigation.frm_fumis _frm_fumi;
        private void btn_fumigation_2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_fumi == null || _frm_fumi.IsDisposed)
                _frm_fumi = new UI_Module.Fumigation.frm_fumis ();
            _frm_fumi.WindowState = FormWindowState.Maximized;
            _frm_fumi.MdiParent = this;
            _frm_fumi.Show();

        }
        UI_Module.System_Main.frm_running_fcno _frm_running_fcno;
        private void btn_running_no_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frm_running_fcno == null || _frm_running_fcno.IsDisposed)
                _frm_running_fcno = new UI_Module.System_Main.frm_running_fcno();
            // _frm_password_change.WindowState = FormWindowState.Maximized;
            // _frm_password_change.MdiParent = this;
            if (_frm_running_fcno.ShowDialog() == DialogResult.Yes) { }
            else this.Close();

        }
    }
}