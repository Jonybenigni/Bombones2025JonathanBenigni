using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bombones2025.Datos.Repositorios
{
    public class RellenoRepositorio
    {
        //Atributo privado del repo donde se almacenan los paises
        private List<Relleno> rellenos = new();
        private readonly string ruta = null!;
        public RellenoRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }
        /// <summary>
        /// Método para enviar la lista de países a otra capa
        /// </summary>
        /// <returns></returns>
        public List<Relleno> GetRellenos()
        {
            return rellenos.OrderBy(p => p.NombreRelleno).ToList();
        }
        /// <summary>
        /// Método para leer los países desde el archivo secuencial
        /// </summary>
        /// <param name="ruta">Se pasa el nombre del archivo</param>
        private void LeerDatos()
        {
            if (!File.Exists(ruta))
            {
                return;
            }
            var registros = File.ReadAllLines(ruta);
            foreach (var registro in registros)
            {
                Relleno relleno = ConstruirRelleno(registro);
                rellenos.Add(relleno);
            }

        }
        /// <summary>
        /// Método privado para obtener un país
        /// </summary>
        /// <param name="registro">Recibe un string con los datos del país separados por |</param>
        /// <returns>Un pais</returns>
        private Relleno ConstruirRelleno(string registro)
        {
            var campos = registro.Split('|');
            var rellenoId = int.Parse(campos[0]);
            var nombreRelleno = campos[1];
            return new Relleno()
            {
                NombreRelleno = nombreRelleno,
                RellenoId = rellenoId,
            };
        }
        /// <summary>
        /// Método para retornar el id  más alto  que tengo
        /// dentro de la lista de Paises, sumándole 1
        /// </summary>
        /// <returns></returns>
        private int SetearRellenoId()
        {
            if (rellenos.Any())
                return rellenos.Max(p => p.RellenoId) + 1;
            else
                return 1;
        }

        public bool Existe(Relleno relleno)
        {
            return relleno.RellenoId == 0 ? rellenos.Any(p => p.NombreRelleno == relleno.NombreRelleno) :
                rellenos.Any(p => p.NombreRelleno == relleno.NombreRelleno && p.RellenoId != relleno.RellenoId);
        }
        public void Agregar(Relleno relleno)
        {
            relleno.RellenoId = SetearRellenoId();
            rellenos.Add(relleno);
            if (File.Exists(ruta))
            {
                var registros = File.ReadAllText(ruta);
                if (!string.IsNullOrEmpty(registros) && !registros.EndsWith(Environment.NewLine))
                {
                    File.WriteAllText(ruta, Environment.NewLine);

                }
            }
            using (var escritor = new StreamWriter(ruta, true))
            {
                string linea = ConstruirLinea(relleno);
                escritor.WriteLine(linea);
            }
        }

        private string ConstruirLinea(Relleno relleno)
        {
            return $"{relleno.RellenoId}|{relleno.NombreRelleno}";
        }

        public void Borrar(Relleno relleno)
        {
            Relleno? rellenoBorrar = rellenos.FirstOrDefault(p => p.NombreRelleno == relleno.NombreRelleno);
            if (rellenoBorrar is null)
            {
                return;
            }
             rellenos.Remove(rellenoBorrar);

            var registros = rellenos.Select(p => ConstruirLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);

        }

        public void Editar(Relleno relleno)
        {
            var RellenoEditado = rellenos.FirstOrDefault(p => p.RellenoId == relleno.RellenoId);
            if (RellenoEditado is null)
            {
                return;
            }
            RellenoEditado.NombreRelleno = relleno.NombreRelleno;
            var registros = rellenos.Select(p => ConstruirLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);


        }
    }



}

