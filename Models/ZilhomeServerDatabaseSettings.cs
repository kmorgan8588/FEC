using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zilhome_Server.Models
{
    public class ZilhomeServerDatabaseSettings : IZilhomeServerDatabaseSettings
    {
       public string HouseCollectionName { get; set; }
       public string ConnectionString { get; set; }
       public string DatabaseName { get; set; }
    }

    public interface IZilhomeServerDatabaseSettings
    {
        string HouseCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
