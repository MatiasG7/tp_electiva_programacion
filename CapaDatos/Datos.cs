using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CapaDatos
{
    public class Datos
    {
        public static bool Guardar(object o)
        {
            bool ok = false;

            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("Club.dat", FileMode.Create);
                bf.Serialize(miArchivo, o);
                miArchivo.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
            }

            return ok;
        }
        public static object Recuperar()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("Club.dat", FileMode.Open);
                object o = bf.Deserialize(miArchivo);
                miArchivo.Close();
                return o;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
