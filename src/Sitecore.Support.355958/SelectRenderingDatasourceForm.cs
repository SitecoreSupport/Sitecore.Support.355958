using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.Shell.Applications.Dialogs;
using Sitecore.Shell.Applications.Dialogs.ItemLister;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.XA.Foundation.Multisite.Extensions;
using Sitecore.XA.Foundation.SitecoreExtensions.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.XA.Foundation.LocalDatasources.Dialogs
{
    public class SelectRenderingDatasourceForm : Sitecore.XA.Foundation.LocalDatasources.Dialogs.SelectRenderingDatasourceForm
    {
        protected new void OnLoad(EventArgs e)
        {
            Assert.ArgumentNotNull(e, "e");
            base.OnLoad(e);
            if (!Context.ClientPage.IsEvent)
            {                
                ((DatasourceMultiRootTreeview)base.Treeview).ShowNodeExtendedCommands = true;
            }
        }
    }
}