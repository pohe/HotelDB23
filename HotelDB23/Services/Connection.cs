using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB23.Services
{
    public abstract class Connection
    {
        protected String connectionString = @"Data Source=mssql17.unoeuro.com;Initial Catalog=pohe_zealand_dk_db_poul;User ID=pohe_zealand_dk;Password=mc6ynw4fBr5b;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
