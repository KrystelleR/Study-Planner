using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ProjectWebApp.ModuleLibrary
{
   public static class Connections
    {
        public static SqlConnection GetConeection()
        {
            //string fileName = "ProjectDB.mdf";
            //string filePath = Path.GetFullPath(fileName);
            //string strCon = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={filePath};Integrated Security=True";
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\BCAD\Semester 4\PROG6212\POE\Part 3\ProjectWebApp\ProjectWebApp\ProjectWebApp\Data\ProjectDB.mdf;Integrated Security=True");
        }
    }
}
