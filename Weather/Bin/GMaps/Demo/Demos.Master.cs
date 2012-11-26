using System;
using System.IO;
using System.Web;

namespace Demos
{
    public partial class Demos : System.Web.UI.MasterPage
    {
        protected string AspxFile, AspxCode, CsFile, CsCode;

        protected void Page_Load(object sender, EventArgs e)
        {
            string aspxPath;
            string aspxContents, csContents;

            aspxPath = this.Request.PhysicalPath;
            
            try
            {
                aspxContents = File.ReadAllText(aspxPath);
            }
            catch
            {
                aspxContents = string.Empty;
            }

            try
            {
                csContents = File.ReadAllText(aspxPath + ".cs");
            }
            catch
            {
                csContents = string.Empty;
            }

            AspxFile = Path.GetFileName(aspxPath);
            AspxCode = HttpUtility.HtmlEncode(aspxContents);
            CsFile = Path.GetFileName(aspxPath + ".cs");
            CsCode = HttpUtility.HtmlEncode(csContents);
        }
    }
}