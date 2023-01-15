using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader_Component.DatabaseConnection
{
    internal class ConnectionParam
    {
        //TODO: Ukoliko koristite SUBP u VM, a Visual Studio van VM promenite localhost sa IP adresom VM
        public static readonly string LOCAL_DATA_SOURCE = "//localhost:1521/xe";
        public static readonly string CLASSROOM_DATA_SOURCE = "//192.168.0.102:1522/db2016";

        //TODO: promeniti username i password
        public static readonly string USER_ID = "Exxxxx";
        public static readonly string PASSWORD = "ftn";

    }
}
