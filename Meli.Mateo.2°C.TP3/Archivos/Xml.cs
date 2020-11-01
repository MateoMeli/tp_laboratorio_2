using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Archivos;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T : class
    {
        public bool Guardar(string archivo, T datos)
        {
            bool guardado = false;
            XmlSerializer xmlSerializer;
            XmlTextWriter xmlTextWriter;
            try
            {
                if(datos != null)
                {
                    xmlTextWriter = new XmlTextWriter(archivo, Encoding.UTF8);
                    xmlSerializer = new XmlSerializer(typeof(T));

                    xmlTextWriter.Formatting = Formatting.Indented;
                    xmlSerializer.Serialize(xmlTextWriter, datos);
                    guardado = true;
                }
                return guardado;
            }
            catch(Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }

        public bool Leer(string archivos, out T datos)
        {
            bool leyo = false;
            datos = default;
            try
            {
                if (File.Exists(archivos))
                {
                    using (XmlTextReader reader = new XmlTextReader(archivos))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        if (ser.CanDeserialize(reader)) 
                        {
                            datos = (T)ser.Deserialize(reader);
                            leyo = true;
                        }
                    }

                }
                else
                {
                    throw new Exception();
                }
                return leyo;

            }catch(Exception ex)
            {
                throw new ArchivosException(ex);
            }
            
        }
    }

}
