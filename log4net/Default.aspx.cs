using System;
using System.Collections.Generic;
using log4net;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace log4net

{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ILog logger = LogManager.GetLogger(typeof(Default));
            try
            {
                logger.Info("ban dang vao load default");
            }
            catch (Exception)
            {
                logger.Error("code bị lỗi");
            }
        }
    }
}