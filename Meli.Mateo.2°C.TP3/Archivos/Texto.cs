using Excepciones;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool guardo = false;

            try
            {
                if(datos != null)
                {
                    using (StreamWriter sw = new StreamWriter(archivo, false, Encoding.UTF8))
                    {
                        sw.WriteLine(datos);
                        guardo = true;
                    }
                }
            }catch(Exception ex)
            {
                throw new ArchivosException(ex);
            }
            return guardo;
        }

        public bool Leer(string archivos, out string datos)
        {
            bool leyo = false;

            try
            {
                if (File.Exists(archivos))
                {
                    using(StreamReader sr = new StreamReader(archivos))
                    {
                        datos = sr.ReadToEnd();
                        leyo = true;
                    }
                }
                else
                {
                    throw new Exception();
                }
            }catch(Exception ex)
            {
                throw new ArchivosException(ex);
            }
            
            return leyo;
        }
    }
}
