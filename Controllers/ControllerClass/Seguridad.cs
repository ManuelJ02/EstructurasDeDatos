using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Seguridad
    {
        public static string Encriptar(string valor)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();

                byte[] datos = md5.ComputeHash(utf8.GetBytes(valor));
                return Convert.ToBase64String(datos);
            }
        }
    }
}

