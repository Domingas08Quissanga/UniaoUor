using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

    public class Conexao
    {
         private static string ConString = "Server=localhost; Database=ProjectoUor; uid=root; Password=;";
            public static MySqlConnection Conectar()
            {
                MySqlConnection Con= new MySqlConnection(ConString);
                Con.Open();
                 return Con;
            }
    }
