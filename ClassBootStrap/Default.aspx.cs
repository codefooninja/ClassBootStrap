using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassBootStrap
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //CSV import. Check columns first
            List<String> UserNames = CSVManager.Import(string FilePath);

            //Create AD Users
            ADManager.CreateAD(UserNames);

            //Create databases
            List<DatabaseProjects> databases = DatabaseManager.CreateDatabases(UserNames);

            //grant permissions on databases
            DatabaseManager.GrantPermissions(databases);

            //Create IIS websites
            List<IISProjects> sites= IISManager.CreateWebsites(databases);

            IISManager.GrantFTPSites(IISProjects);

            IISManager.CreateGITRepos
            
            //Book outlook resources
            OutlookManager.ScheduleClassrooms(UserNames,StartDate);
            OutlookManager.CreateDistributionList(UserNames);

        }
    }
}