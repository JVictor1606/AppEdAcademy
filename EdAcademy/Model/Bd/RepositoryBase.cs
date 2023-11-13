using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdAcademy.Model.Bd
{
    public class RepositoryBase
    {
        private readonly string _connextionString;

        public RepositoryBase()
        {

            _connextionString = "Server=localhost\\SQLEXPRESS;Database=EdAcademy;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connextionString);
        }
    }
}
