using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using System.Drawing;

using System.Drawing.Imaging;
using MP_HR.LINQ;
using MP_HR;

namespace MP_HR.Controller
{
    public static  class Controller_Image
    {

        public static void DeleteImage(string ImageID)
        {
            LINQ_ImageDataContext dc = new LINQ_ImageDataContext(Program.get_image_connection());
            Mst_Image the_image = (from c in dc.Mst_Images where c.ImageID == ImageID select c).FirstOrDefault();
            if (the_image != null)
            {
                dc.Mst_Images.DeleteOnSubmit(the_image);
                dc.SubmitChanges();
            }
        }

        public static  string SaveImage(System.Drawing.Bitmap save_image, string image_tranaction_type,string image_id)
        {
            try
            {
                if (image_id != "")
                    DeleteImage(image_id);
                
                MemoryStream ms = new MemoryStream();

                save_image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] ba = ms.ToArray();



                LINQ_ImageDataContext dc = new LINQ_ImageDataContext(Program.get_image_connection());
                Mst_Image the_image = new Mst_Image()
                {
                    CreatedBy = Program.get_current_user_id(),
                    ModifiedBy = Program.get_current_user_id(),
                    ModifiedOn = DateTime.Now,
                    CreatedOn = DateTime.Now,
                    ImageID = Guid.NewGuid().ToString(),
                    Active = true,
                    LastAction = Guid.NewGuid().ToString(),
                    ImageData = ba,
                      ImageRecordType=image_tranaction_type

                };
                dc.Mst_Images.InsertOnSubmit(the_image);
                dc.SubmitChanges(); 
               
                return the_image.ImageID;
            }
            catch (Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }
        public static Image GetImage(string ImageID)
        {
            LINQ_ImageDataContext dc = new LINQ_ImageDataContext(Program.get_image_connection());
            Mst_Image transaction_image = (from c in dc.Mst_Images
                                                 where c.ImageID == ImageID
                                                 select c).FirstOrDefault();
            if (transaction_image != null)
                return ConvertToImage(transaction_image.ImageData);
            else
                return null;
        }
        public static Image ConvertToImage(System.Data.Linq.Binary iBinary)
        {
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary))
            {
                rImage = Image.FromStream(ms);
            }
            return rImage;
        }
    }
}
