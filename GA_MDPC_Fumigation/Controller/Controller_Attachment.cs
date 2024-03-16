using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
namespace MP_HR.Controller
{
    public static class Controller_Attachment
    {
        public static Mst_Attached OpenAttachment(string attachedID)
        {
        LINQ_AttachmentDataContext dc_attached = new LINQ_AttachmentDataContext(Program.get_image_connection());
            return (from c in dc_attached.Mst_Attacheds
                    where c.AttachedID==attachedID
              select c).FirstOrDefault();
        }

        public static string DeleteAttachment(string attachedid, string referenceType)
        {
            string Result = "";
            if (MessageBox.Show("Are you sure you want to delete this record?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LINQ_AttachmentDataContext dc = new LINQ_AttachmentDataContext(Program.get_image_connection());
                Mst_Attached the_record = (from c in dc.Mst_Attacheds where c.AttachedID == attachedid select c).FirstOrDefault();

                dc.Mst_Attacheds.DeleteOnSubmit(the_record);
                dc.SubmitChanges();
           
            }
            return Result;
        }

        public static List<Mst_Attached> GetAttachedFileList(string referenceID, string searchText)
        {
            LINQ_AttachmentDataContext dc_attached = new LINQ_AttachmentDataContext(Program.get_image_connection());
            
        return   (from c in dc_attached.Mst_Attacheds
                    where c.ReferenceID == referenceID
                       && (( searchText != "" &&  c.FileName.Contains(searchText)) || (searchText == ""))
                    orderby c.CreatedOn descending
                    select c).ToList();
         

          
        }
        public static string AttachedFile(OpenFileDialog dlg, string referenceId, string referenceType, string userid)
        {
            string result = "Attached successfully.";
            try
            {


                LINQ_AttachmentDataContext dc_attached = new LINQ_AttachmentDataContext(Program.get_image_connection());
                Mst_Attached the_attach = new Mst_Attached()
                {
                    CreatedBy = userid,
                    ModifiedBy = userid,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    LastAction = Guid.NewGuid().ToString(),
                    AttachedID = Guid.NewGuid().ToString(),
                    Active = true,
                    AttachedData = System.IO.File.ReadAllBytes(dlg.FileName),
                    FileExtenstion = Path.GetExtension(dlg.FileName),
                    FileName = Path.GetFileName(dlg.FileName),
                    FilePath = dlg.FileName,
                    FileSize = new FileInfo(dlg.FileName).Length / 1000,
                    FileType = Path.GetExtension(dlg.FileName),
                    ReferenceID = referenceId,
                    ReferenceType = referenceType
                };
                dc_attached.Mst_Attacheds.InsertOnSubmit(the_attach);
                dc_attached.SubmitChanges();
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
