using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Wuyiju.Web.Utils
{
    public static class FileHelper
    {
        public static string Upload(this HttpPostedFile file, string savePath)
        {
            if (file != null)
            {
                if (!System.IO.Directory.Exists(savePath))
                    System.IO.Directory.CreateDirectory(savePath);

                var exts = file.FileName.Split('.');
                if (exts.Length == 0)
                    throw new ApplicationException("仅支持图片格式");

                var ext = exts[exts.Length - 1].TryParseToString("").ToLower();

                var filename = string.Format("{0}.{1}", Guid.NewGuid(), ext);

                if ("jpg".Equals(ext) || "jpeg".Equals(ext) || "png".Equals(ext))
                {
                    file.SaveAs(savePath + filename);
                }

                return filename;

            }

            return null;
        }
    }
}
