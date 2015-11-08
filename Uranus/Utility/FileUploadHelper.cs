using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uranus.Utility
{
    public class FileUploadHelper : Controller
    {


        private string[] validImageTypes = new string[]
        {
            "image/gif",
            "image/jpeg",
            "image/pjpeg",
            "image/png"
        };

        public string ErrorMessage = "Please choose either a GIF, JPG or PNG image.";
        public string SaveImages()
        {
            try
            {

                var destinationFolder = System.Web.HttpContext.Current.Server.MapPath("~/Images");
                foreach (var name in System.Web.HttpContext.Current.Request.Files)
                {
                    var postedFile = System.Web.HttpContext.Current.Request.Files[name.ToString()];
                    if (postedFile != null)
                    {
                        if (postedFile.FileName == "")
                        {
                            return "";
                        }
                    }
                    if (postedFile != null && !validImageTypes.Contains(postedFile.ContentType))
                    {
                        return ErrorMessage;
                    }
                    string url = Guid.NewGuid().ToString() + Path.GetExtension(postedFile.FileName);
                    if (postedFile.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(postedFile.FileName);
                        var path = Path.Combine(destinationFolder, url);
                        postedFile.SaveAs(path);
                        return url;
                    }
                }
                return "";
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}