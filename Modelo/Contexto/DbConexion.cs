using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    public partial class DBConexion : DbContext
    {
        private DBConexion(string stringConexion) 
            :  base(stringConexion)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.CommandTimeout = 900;
        }

        public static DBConexion Create()
        {
            return new DBConexion("name=DBConexion");
        }
    }
}
