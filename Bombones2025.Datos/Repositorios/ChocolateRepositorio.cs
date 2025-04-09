using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bombones2025.Datos.Repositorios
{
    public class ChocolateRepositorio
    {
            
            private List<Chocolate> chocolates = new();
            private readonly string ruta = null!;
            public ChocolateRepositorio(string rutaArchivo)
            {
                ruta = rutaArchivo;
                LeerDatos();
            }
            /// <summary>
            /// Método para enviar la lista de países a otra capa
            /// </summary>
            /// <returns></returns>
            public List<Chocolate> GetChocolate()
            {
                return chocolates.OrderBy(p => p.NombreChocolate).ToList();
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
                    Chocolate chocolate = ConstruirChocolate(registro);
                    chocolates.Add(chocolate);
                }

            }
            /// <summary>
            /// Método privado para obtener un país
            /// </summary>
            /// <param name="registro">Recibe un string con los datos del país separados por |</param>
            /// <returns>Un pais</returns>
            private Chocolate ConstruirChocolate(string registro)
            {
                var campos = registro.Split('|');
                var ChocolateId = int.Parse(campos[0]);
                var nombreChocolate = campos[1];
                return new Chocolate()
                {
                    NombreChocolate = nombreChocolate,
                    ChocolateId = ChocolateId,
                };
            }
            /// <summary>
            /// Método para retornar el id  más alto  que tengo
            /// dentro de la lista de Paises, sumándole 1
            /// </summary>
            /// <returns></returns>
            private int SetearChocolateId()
            {
                return chocolates.Max(p => p.ChocolateId) + 1;
            }

            public bool Existe(Chocolate chocolate)
            {
                return chocolate.ChocolateId == 0 ? chocolates.Any(p => p.NombreChocolate == chocolate.NombreChocolate) :
                    chocolates.Any(p => p.NombreChocolate == chocolate.NombreChocolate && p.ChocolateId != chocolate.ChocolateId);
            }
            public void Agregar(Chocolate chocolate)
            {
                chocolate.ChocolateId = SetearChocolateId();
                chocolates.Add(chocolate);

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
                    string linea = ConstruirLinea(chocolate);
                    escritor.WriteLine(linea);
                }
            }

            private string ConstruirLinea(Chocolate chocolate)
            {
                return $"{chocolate.ChocolateId}|{chocolate.NombreChocolate}";
            }

            public void Borrar(Chocolate chocolate)
            {
                Chocolate? chocolateBorrar = chocolates.FirstOrDefault(p => p.NombreChocolate == chocolate.NombreChocolate);
                if (chocolateBorrar is null)
                {
                    return;
                }

                chocolates.Remove(chocolateBorrar);

                var registros = chocolates.Select(p => ConstruirLinea(p)).ToArray();
                File.WriteAllLines(ruta, registros);

            }

            public void Editar(Chocolate chocolate)
            {
                var chocolateEditado = chocolates.FirstOrDefault(p => p.ChocolateId == chocolate.ChocolateId);

                if (chocolateEditado is null)
                {
                    return;
                }

                chocolateEditado.NombreChocolate = chocolate.NombreChocolate;
                var registros = chocolates.Select(p => ConstruirLinea(p)).ToArray();
                File.WriteAllLines(ruta, registros);


            }
        
    }
}
