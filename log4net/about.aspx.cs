using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace log4net
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ILog logger = LogManager.GetLogger(typeof(About));
            logger.Info("ban dang vao load About");

        }
    }
}