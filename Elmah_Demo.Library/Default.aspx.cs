﻿using Elmah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Elmah_Demo.Library
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception ex)
            {
                //ErrorLog.GetDefault(null).Log(new Error(ex));
                ErrorSignal.FromCurrentContext().Raise(ex);
            }
        }
    }
}