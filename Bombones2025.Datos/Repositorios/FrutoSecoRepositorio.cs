using Bombones2025.Entidades;

namespace Bombones2025.Datos.Repositorios
{
    public class FrutoSecoRepositorio
    {
        //Atributo privado del repo donde se almacenan los paises
        private List<FrutoSeco> frutosSecos = new();
        private readonly string ruta = null!;
        public FrutoSecoRepositorio(string rutaArchivo)
        {
            ruta=rutaArchivo;
            LeerDatos();
        }
        /// <summary>
        /// Método para enviar la lista de países a otra capa
        /// </summary>
        /// <returns></returns>
        public List<FrutoSeco> GetLista()
        {
            return frutosSecos.OrderBy(p => p.NombreFrutosSecos).ToList();
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
                FrutoSeco fruto = ConstruirFruto(registro);
                frutosSecos.Add(fruto);
            }

        }
        /// <summary>
        /// Método privado para obtener un fruto seco
        /// </summary>
        /// <param name="registro">Recibe un string con los datos del país separados por |</param>
        /// <returns>Un pais</returns>
        private FrutoSeco ConstruirFruto(string registro)
        {
            var campos = registro.Split('|');
            var frutoSecoId = int.Parse(campos[0]);
            var descripcion = campos[1];
            return new FrutoSeco()
            {
                NombreFrutosSecos = descripcion,
                FrutoSecoId = frutoSecoId
            };
        }

        private int SetearFrutosSecosId()
        {
            if (frutosSecos.Any())
                return frutosSecos.Max(p => p.FrutoSecoId) + 1;
            else
                return 1;
        }
        public bool Existe(FrutoSeco frutoSeco)
        {
            return frutoSeco.FrutoSecoId == 0 ? frutosSecos.Any(p => p.NombreFrutosSecos == frutoSeco.NombreFrutosSecos) :
                frutosSecos.Any(p => p.NombreFrutosSecos == frutoSeco.NombreFrutosSecos && p.FrutoSecoId != frutoSeco.FrutoSecoId);
        }

        private string ConstruirLinea(FrutoSeco frutoSeco)
        {
            return $"{frutoSeco.FrutoSecoId}|{frutoSeco.NombreFrutosSecos}";
        }

        public void Agregar(FrutoSeco frutoSeco)
        {
            frutoSeco.FrutoSecoId = SetearFrutosSecosId();
            frutosSecos.Add(frutoSeco);
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
                string linea = ConstruirLinea(frutoSeco);
                escritor.WriteLine(linea);
            }
        }

        public void Editar(FrutoSeco frutoSeco)
        {
            var FrutoSecoEditado = frutosSecos.FirstOrDefault(p => p.FrutoSecoId == frutoSeco.FrutoSecoId);
            if (FrutoSecoEditado is null)
            {
                return;
            }
            FrutoSecoEditado.NombreFrutosSecos = frutoSeco.NombreFrutosSecos;
            var registros = frutosSecos.Select(p => ConstruirLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);


        }

        public void Borrar(FrutoSeco frutoSeco)
        {
            FrutoSeco? frutosecoBorrar= frutosSecos.FirstOrDefault(p => p.NombreFrutosSecos == frutoSeco.NombreFrutosSecos);
            if (frutosecoBorrar is null)
            {
                return;
            }
            frutosSecos.Remove(frutosecoBorrar);

            var registros = frutosSecos.Select(p => ConstruirLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);

        }
    }
}
