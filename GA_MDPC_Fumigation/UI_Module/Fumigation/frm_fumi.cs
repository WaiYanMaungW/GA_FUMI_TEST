using GA_MDPC_Fumigation.LINQ;
using GA_MDPC_Fumigation.UI_Module.Selection;
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
    public partial class frm_fumi : Form
    {
        public frm_fumi()
        {
            InitializeComponent();
        }
        public string record_id = "";
        private void frm_fumi_Load(object sender, EventArgs e)
        {
            if (record_id == "")
            {
                do_new();
              //  tb_FC_NO.Text = Controller.Controller_Running_No.GetNewRunningNo_Check("FUMI");
            }
            else
                do_load();
        }

        public string selected_unit_id_1 = "";
        private void btn_unit1_Click(object sender, EventArgs e)
        {
            select_units the_selection = new select_units();
            the_selection.selected_value1 = selected_unit_id_1;
            the_selection.selected_text1 = tb_unit1.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_unit_id_1 = the_selection.selected_value1;
                tb_unit1.Text = the_selection.selected_text1;
            }
            tb_net_weight.Focus();
        }
        public string selected_unit_id_2 = "";
        private void btn_unit2_Click(object sender, EventArgs e)
        {
            select_units the_selection = new select_units();
            the_selection.selected_value1 = selected_unit_id_2;
            the_selection.selected_text1 = tb_unit2.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_unit_id_2 = the_selection.selected_value1;
                tb_unit2.Text = the_selection.selected_text1;
            }
            tb_no_and_description_packages.Focus();
        }
        public string selected_place_of_loading_id = "";
        private void btn_place_of_loading_Click(object sender, EventArgs e)
        {
            select_PlaceOfLoading the_selection = new select_PlaceOfLoading();
            the_selection.selected_value1 = selected_place_of_loading_id;
            the_selection.selected_text1 = tb_place_of_loading.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_place_of_loading_id = the_selection.selected_value1;
                tb_place_of_loading.Text = the_selection.selected_text1;
            }
            tb_exporter_name.Focus();
        }

        private void btn_place_of_fumigation_Click(object sender, EventArgs e)
        {
            tb_place_of_loading.Text = "";
            selected_place_of_loading_id = "";
        }

        public string selected_exporter_id = "";
        public string selected_exporter_address_id = "";
        private void select_exporter_selection()
        {
            select_exporter the_selection = new select_exporter();
            the_selection.selected_value1 = selected_exporter_id;
            the_selection.selected_text1 = tb_exporter_name.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_exporter_id = the_selection.selected_value1;
                tb_exporter_name.Text = the_selection.selected_text1;
                selected_exporter_address_id = the_selection.selected_value2;
               // tb_exporter_address.Text = the_selection.selected_text2;
            }
           tb_means_of_conveyance.Focus();
        }

        private void btn_exporter_Click(object sender, EventArgs e)
        {
            select_exporter_selection();
        }
        public string selected_means_of_conveyance_id = "";
        private void btn_means_of_conveyance_Click(object sender, EventArgs e)
        {
            select_conveyance the_selection = new select_conveyance();
            the_selection.selected_value1 = selected_means_of_conveyance_id;
            the_selection.selected_text1 = tb_means_of_conveyance.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_means_of_conveyance_id = the_selection.selected_value1;
                tb_means_of_conveyance.Text = the_selection.selected_text1;
            }
            tb_destination.Focus();

        }
        public string selected_destintaion_id = "";
        private void btn__destination_Click(object sender, EventArgs e)
        {
            select_destination the_selection = new select_destination();
            the_selection.selected_value1 = selected_destintaion_id;
            the_selection.selected_text1 = tb_destination.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_destintaion_id = the_selection.selected_value1;
                tb_destination.Text = the_selection.selected_text1;
            }
            dtp_fumigation.Focus();
        }
        public string selected_chemical_id = "";
        private void btn_chemical_Click(object sender, EventArgs e)
        {
            select_chemical the_selection = new select_chemical();
            the_selection.selected_value1 = selected_chemical_id;
            the_selection.selected_text1 = tb_chemical.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_chemical_id = the_selection.selected_value1;
                tb_chemical.Text = the_selection.selected_text1;
            }
            tb_concentration.Focus();
        }
        public string selected_concentration_id = "";
        private void btn_concentration_Click(object sender, EventArgs e)
        {
            select_concentration the_selection = new select_concentration();
            the_selection.selected_value1 = selected_concentration_id;
            the_selection.selected_text1 = tb_concentration.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_concentration_id = the_selection.selected_value1;
                tb_concentration.Text = the_selection.selected_text1;
            }
            tb_temperature.Focus();

        }
        public string selected_exposure_period_id = "";
        private void btn_exposure_period_Click(object sender, EventArgs e)
        {
            select_exposure_period the_selection = new select_exposure_period();
            the_selection.selected_value1 = selected_exposure_period_id;
            the_selection.selected_text1 = tb_exposure_period.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_exposure_period_id = the_selection.selected_value1;
                tb_exposure_period.Text = the_selection.selected_text1;
            }
            tb_distinguishing_marks.Focus();

        }
        public string selected_temperature_id = "";
        private void btn_temperature_Click(object sender, EventArgs e)
        {
            select_temperature the_selection = new select_temperature();
            the_selection.selected_value1 = selected_temperature_id;
            the_selection.selected_text1 = tb_temperature.Text;
            if (the_selection.ShowDialog() == DialogResult.Yes)
            {
                selected_temperature_id = the_selection.selected_value1;
                tb_temperature.Text = the_selection.selected_text1;
            }
            tb_exposure_period.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            do_save_record();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            do_new();
        }
        void do_new()
        {
            record_id = "";
            tb_FC_NO.Text = Controller.Controller_Running_No.GetNewRunningNo_Check("FUMI");
            tb_exporter_name.Text = "";
           // tb_exporter_address.Text = "";
           // tb_consignee_name.Text = "";
           // tb_consignee_address.Text = "";
            tb_commodity.Text = "";
            tb_gross_weight.Text = "";
            tb_net_weight.Text = "";
            tb_unit1.Text = "";
            tb_unit2.Text = "";
            tb_no_and_description_packages.Text = "";
            tb_distinguishing_marks.Text = "";
            tb_place_of_loading.Text = "";
            tb_destination.Text = "";
            tb_means_of_conveyance.Text = "";
            tb_additional_declaration.Text = "";

            tb_chemical.Text = "";
            tb_concentration.Text = "";
            tb_exposure_period.Text = "";
            tb_temperature.Text = "";
          //  tb_place_of_issued.Text = "";
           // tb_authorized_signature.Text = "";
            dtp_fumigation.Value = DateTime.Now;
            dtp_issued.Value = DateTime.Now;

            lbl_message.Text = "";


            btn_delete.Enabled = false;
            tb_exporter_name.Focus();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool do_save_record_verify()
        {
            lbl_message.Text = "";
            bool is_error = false;
            if (tb_exporter_name.Text.Trim() == "")
            {
                is_error = true;
                tb_exporter_name.Focus();
                lbl_message.Text = "Need to type Exporter Name";
            }
          
            else if (tb_commodity.Text.Trim() == "")
            {
                is_error = true;
                tb_commodity.Focus();
                lbl_message.Text = "Need to type Commodity";
            }
            else if (tb_gross_weight.Text.Trim() == "")
            {
                is_error = true;
                tb_gross_weight.Focus();
                lbl_message.Text = "Need to type Gross Weight";
            }
            else if (tb_net_weight.Text.Trim() == "")
            {
                is_error = true;
                tb_net_weight.Focus();
                lbl_message.Text = "Need to type Net Weight";
            }
            else if (tb_unit1.Text.Trim() == "")
            {
                is_error = true;
                tb_unit1.Focus();
                lbl_message.Text = "Need to type Gross Weight Unit";
            }
            else if (tb_unit2.Text.Trim() == "")
            {
                is_error = true;
                tb_unit2.Focus();
                lbl_message.Text = "Need to type Net Weight Unit";
            }
            else if (tb_no_and_description_packages.Text.Trim() == "")
            {
                is_error = true;
                tb_no_and_description_packages.Focus();
                lbl_message.Text = "Need to type Number and description of packages";
            }
             if (tb_distinguishing_marks.Text.Trim() == "")
            {
                tb_distinguishing_marks.Text = "NONE";
                //is_error = true;
                //tb_distinguishing_marks.Focus();
                //lbl_message.Text = "Need to type Distinguishing marks";
            }
            else if (tb_place_of_loading.Text.Trim() == "")
            {
                is_error = true;
                tb_place_of_loading.Focus();
                lbl_message.Text = "Need to type Place of Fumigation";
            }
            else if (tb_means_of_conveyance.Text.Trim() == "")
            {
                is_error = true;
                tb_means_of_conveyance.Focus();
                lbl_message.Text = "Need to type Means of conveyance";
            }
            else if (tb_destination.Text.Trim() == "")
            {
                is_error = true;
                tb_destination.Focus();
                lbl_message.Text = "Need to type Destination";
            }
             if (tb_additional_declaration.Text.Trim() == "")
            {
                tb_additional_declaration.Text = "NIL";
                //is_error = true;
                //tb_additional_declaration.Focus();
                //lbl_message.Text = "Need to type Additional declaration";
            }
            else if (tb_chemical.Text.Trim() == "")
            {
                is_error = true;
                tb_chemical.Focus();
                lbl_message.Text = "Need to type Name of Chemical";
            }
            else if (tb_concentration.Text.Trim() == "")
            {
                is_error = true;
                tb_concentration.Focus();
                lbl_message.Text = "Need to type Concentration";
            }
            else if (tb_exposure_period.Text.Trim() == "")
            {
                is_error = true;
                tb_exposure_period.Focus();
                lbl_message.Text = "Need to type Exposure Period";
            }
            else if (tb_temperature.Text.Trim() == "")
            {
                is_error = true;
                tb_temperature.Focus();
                lbl_message.Text = "Need to type Temperature";
            }
            if (tb_container_no.Text.Trim() == "")
            {
                tb_container_no.Text = "NIL";
                //is_error = true;
                //tb_additional_declaration.Focus();
                //lbl_message.Text = "Need to type Additional declaration";
            }


            return is_error;
        }
        public bool AutoCloseAfterSave = false;
        string do_save_record()
        {

            btn_delete.Enabled = true;
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            Mst_Fumigation the_record = new Mst_Fumigation();

            try
            {
                if (do_save_record_verify()) return "";

                if (record_id != "")
                {
                    the_record = (from c in dc.Mst_Fumigations where record_id == c.FumigationID select c).FirstOrDefault();

                }
                else
                {
                    
                        the_record = new Mst_Fumigation()
                        {

                            CreatedBy = Program.get_current_user_id(),
                            CreatedOn = DateTime.Now,
                            Active = true,
                            LastAction = Guid.NewGuid().ToString(),
                            FumigationID = Guid.NewGuid().ToString(),
                            ModifiedOn = DateTime.Now,
                            ModifiedBy = Program.get_current_user_id(),
                            //FCNO=tb_FC_NO.Text
                            FCNO = Controller.Controller_Running_No.GetNewRunningNo_Generate("FUMI")

                        };
                        dc.Mst_Fumigations.InsertOnSubmit(the_record);
                   
                }

                //#region updatelog
                //HR_Staff log_obj = dc.GetChangeSet().Updates.OfType<HR_Staff>().FirstOrDefault();
                //if (log_obj != null)
                //{
                //    if (Controller.Controller_SystemLog.WirteUpdateLog(dc.HR_Staffs.GetModifiedMembers(log_obj).ToList(), record_id, Program.get_current_user_name()) == false)
                //        MessageBox.Show("Warning: System cannot write log file");
                //}
                //#endregion

                the_record.ExporterAddressID = selected_exporter_address_id;
               // the_record.ConsigneeAddressID = selected_consignee_address_id;
                the_record.Commodity = tb_commodity.Text;
                the_record.GrossWeight = Convert.ToDecimal(tb_gross_weight.Text);
                the_record.GrossWeightUnitID = selected_unit_id_1;
                the_record.NetWeight = Convert.ToDecimal(tb_net_weight.Text);
                the_record.NetWeightID = selected_unit_id_1;
                the_record.NoAndDecriptionPackage = tb_no_and_description_packages.Text;
                the_record.DistinguishingMark = tb_distinguishing_marks.Text;
                if (selected_place_of_loading_id != "")
                { the_record.PlaceOfLoadingID = selected_place_of_loading_id;
                the_record.PlaceOfFumigation = selected_place_of_loading_id;
                }
                else {
                    the_record.PlaceOfLoadingID = null;
                    the_record.PlaceOfFumigation = tb_place_of_loading.Text;
                }

                the_record.MeanOfConveyanceID = selected_means_of_conveyance_id;
                the_record.DestinationID = selected_destintaion_id;
                the_record.AdditionalDeclaration = tb_additional_declaration.Text;
                the_record.ChemicalID = selected_chemical_id;
                the_record.ConcentrationID = selected_concentration_id;
                the_record.ExposurePeriodID = selected_exposure_period_id;
                the_record.TemperatureID = selected_temperature_id;
                the_record.DateOfFumigation = dtp_fumigation.Value;
                the_record.DateIssued = dtp_issued.Value;

                the_record.ContainerNO = tb_container_no.Text;
                // the_record.PlaceOfIssued = tb_place_of_issued.Text;
                // the_record.AuthorizedSignatureID = selected_authorized_signature_id;
                #region updatelog
                Mst_Fumigation log_obj = dc.GetChangeSet().Updates.OfType<Mst_Fumigation>().FirstOrDefault();
                if (log_obj != null)
                {
                    if (Controller.Controller_SystemLog.WirteUpdateLog(dc.Mst_Fumigations.GetModifiedMembers(log_obj).ToList(), record_id, Program.get_current_user_name()) == false)
                        MessageBox.Show("Warning: System cannot write log file");
                }
                #endregion
                dc.SubmitChanges();

                if (AutoCloseAfterSave) this.DialogResult = DialogResult.Yes;
                MessageBox.Show("Record has been saved.", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (record_id == "new" || record_id == "")
                {
                    record_id = the_record.FumigationID;

                }
                do_load();

                return "success";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed. " + ex.Message, "SORRY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ex.Message;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            do_delete();
        }
        void do_delete()
        { // user access;
            if (MessageBox.Show("Are you sure you want to delete this record?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                      DialogResult.Yes)
            {
                Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
                Mst_Fumigation the_record = new Mst_Fumigation();
                the_record = (from c in dc.Mst_Fumigations where c.Active == true && c.FumigationID == record_id select c).FirstOrDefault();
                if (the_record == null) throw new Exception("System cannot find the record.");
                the_record.Active = false;
                the_record.ModifiedBy = Program.get_current_user_code();
                the_record.ModifiedOn = DateTime.Now;
                the_record.LastAction = Guid.NewGuid().ToString();
                dc.SubmitChanges();
                do_new();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            bool baseResult = base.ProcessCmdKey(ref msg, keyData);

            if (keyData == (Keys.Control | Keys.S))// Save
            {
                do_save_record();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.N)) //New
            {
                do_new();
                return true;
            }
            else if ((keyData == Keys.Escape))//Close
            {
                this.Close();
                return true;
            }
            else if ((keyData == Keys.Delete))
            {
                do_delete();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.P)) //New
            {
                do_print();
                return true;
            }
            return baseResult;


        }
        void do_load()
        {
            //if (theAccess.AllowSelect == false)
            //{
            //    MessageBox.Show("You don't have permission to view this record.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            btn_delete.Enabled = true;
            lbl_message.Text = "";

            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            Mst_FumigationView the_result = (from c in dc.Mst_FumigationViews where c.Active == true && c.FumigationID == record_id select c).FirstOrDefault();
            if (record_id != null || record_id == "")
            {
                tb_FC_NO.Text = the_result.FCNO;

                selected_exporter_address_id = the_result.ExporterAddressID;
                tb_exporter_name.Text = the_result.ExporterName;
              //  tb_exporter_address.Text = the_result.ExporterAddress;

              //  selected_consignee_address_id = the_result.ConsigneeAddressID;
             //   tb_consignee_name.Text = the_result.ConsigneeName;
              //  tb_consignee_address.Text = the_result.ConsigneeAddress;

                tb_commodity.Text = the_result.Commodity;

                tb_gross_weight.Text = the_result.GrossWeight.ToString();
                selected_unit_id_1 = the_result.GrossWeightUnitID;
                tb_unit1.Text = the_result.UnitName1;

                tb_net_weight.Text = the_result.NetWeight.ToString();
                selected_unit_id_1 = the_result.NetWeightID;
                tb_unit2.Text = the_result.UnitName2;

                tb_no_and_description_packages.Text = the_result.NoAndDecriptionPackage;
                tb_distinguishing_marks.Text = the_result.DistinguishingMark;
                if (the_result.PlaceOfLoadingID == the_result.PlaceOfFumigation)
                {
                    selected_place_of_loading_id = the_result.PlaceOfLoadingID;
                    tb_place_of_loading.Text = the_result.PlaceOfLoading;
                }
                else {
                    selected_place_of_loading_id = "";
                    tb_place_of_loading.Text = the_result.PlaceOfFumigation;
                }
               

                selected_means_of_conveyance_id = the_result.MeanOfConveyanceID;
                tb_means_of_conveyance.Text = the_result.CarrierName;

                selected_destintaion_id = the_result.DestinationID;
                tb_destination.Text = the_result.DestinationName;

                tb_additional_declaration.Text = the_result.AdditionalDeclaration;
                selected_chemical_id = the_result.ChemicalID;
                tb_chemical.Text = the_result.ChemicalName;
                selected_concentration_id = the_result.ConcentrationID;
                tb_concentration.Text = the_result.Concentration;
                selected_exposure_period_id = the_result.ExposurePeriodID;
                tb_exposure_period.Text = the_result.ExpouserPeriod;

                selected_temperature_id = the_result.TemperatureID;
                tb_temperature.Text = the_result.Temperature;
                dtp_fumigation.Value = the_result.DateOfFumigation;
                dtp_issued.Value = the_result.DateIssued;
                tb_container_no.Text = the_result.ContainerNO;

              //  tb_place_of_issued.Text = the_result.PlaceOfIssued;
             //   selected_authorized_signature_id = the_result.AuthorizedSignatureID;
              //  tb_authorized_signature.Text = the_result.SignatureName;


                tb_created_on.Text = string.Format("{1} on {0}", the_result.CreatedOn.ToString("dd/MM/yyyy hh:mm tt"), the_result.CreatedByCode);
                tb_modified_on.Text = string.Format("{1} on {0}", the_result.ModifiedOn.ToString("dd/MM/yyyy hh:mm tt"), the_result.ModifiedByCode);


            }
            else { do_new(); }
        }

        Report_fumigation2 _Report_fumigation2 = new Report_fumigation2();
        private void btn_print_Click(object sender, EventArgs e)
        {
            do_print();
        }
        void do_print()
        {
            _Report_fumigation2.fc_no = tb_FC_NO.Text;
            _Report_fumigation2.ShowDialog();
        }

        private void btn_fcno_check_Click(object sender, EventArgs e)
        {
            check_fcno();
        }
        void check_fcno()
        {
            if (tb_FC_NO.BackColor == Color.White)
            {
                tb_FC_NO.BackColor = Color.MediumSpringGreen;
                tb_FC_NO.Enabled = true;
                tb_FC_NO.Focus();
            }
            else
            {
                tb_FC_NO.Enabled = false;
                // tb_FC_NO.BackColor = Color.MediumSpringGreen;
                Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
                Mst_FumigationView the_result = (from c in dc.Mst_FumigationViews where c.Active == true && c.FCNO == tb_FC_NO.Text select c).FirstOrDefault();
                if (the_result == null) tb_FC_NO.BackColor = Color.White;

                else
                {
                    MessageBox.Show("This FC no is already having.", "Duplicate FC NO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    do_new();
                }
            }


        }

        private void btn_log_Click(object sender, EventArgs e)
        {

            if (record_id != "" && record_id != "new")
            {
                UI_Module.System_Main.frm_system_log the_log = new UI_Module.System_Main.frm_system_log();
                the_log.record_id = record_id;
                the_log.Show();

            }
        }
    }
}
