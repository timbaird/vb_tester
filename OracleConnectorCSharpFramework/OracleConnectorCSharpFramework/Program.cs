using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace OracleConnectorCSharpFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("START");

            string connString = "user id=tbaird;password=XXXXXXXX;data source=" +
                                "(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                                "(HOST=feenix-oracle.swin.edu.au)"+
                                "(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=dms)))";


            using (OracleConnection conn = new OracleConnection(connString))
            {

                Console.WriteLine("CONNECTION");
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    Console.WriteLine("COMMAND");
                    try
                    {
                        conn.Open();
                        Console.WriteLine("OPENED");
                        cmd.BindByName = true;
                        Console.WriteLine("BINDING");
                        cmd.CommandText = "select * from genderspelling";
                        Console.WriteLine("QUERY");
                        OracleDataReader reader = cmd.ExecuteReader();
                        Console.WriteLine("EXECUTED");
                        while (reader.Read())
                        {
                            Console.WriteLine("INSIDE");
                            Console.WriteLine("DATA: " + reader.GetString(0));
                        }
                        Console.WriteLine("OUTSIDE");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("EXCEPTION " + e.Message);
                        
                    }
                    finally
                    {
                        conn.Close();
                        
                    }
                }   
            }

            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
