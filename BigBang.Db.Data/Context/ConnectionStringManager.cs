using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net;

namespace Db.Data.Context
{
    public static class Global
    {
        public static string IPCaptura;
    }





    public static class ConnectionStringManager
    {

        public static string GetConnectionString()
        {

            string nome = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(nome);
            var IP = ip[1].ToString();

            // return "Data Source=192.168.0.230;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=OdysimDsm22@";
            //return "Data Source=192.168.7.4;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=Dsm22";
            // return "Data Source=192.168.7.10;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=Dsm22";
            //  return "Data Source=192.168.8.53;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=OdysimDsm22@";
            //  return "Data Source=192.168.10.81;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=OdysimDsm22@";
            return "Data Source=127.0.0.1; Initial Catalog = bigbang; User ID = sa; Password = OdysimDsm22@";
        }
    }
    public class ConnectionStringManagerNew
    {

        public static string GetConnectionString()
        {

            string nome = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(nome);
            var IP = ip[1].ToString();

            //return "Data Source=192.168.0.230;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=OdysimDsm22@";
            //return "Data Source=192.168.7.4;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=Dsm22";
            //return "Data Source=192.168.7.4;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=Dsm22";
            return "Data Source=127.0.0.1; Initial Catalog=bigbang; User ID=sa;Password=OdysimDsm22@";
            //  return "Data Source=192.168.8.53;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=OdysimDsm22@";
            //  return "Data Source=192.168.10.81;Initial Catalog=bigbang; PersistSecurityInfo=True;User ID=sa;Password=OdysimDsm22@";

            //Data Source = 127.0.0.1; Initial Catalog = davidsm; User ID = sa; Password = OdysimDsm22@
        }
    }
}
