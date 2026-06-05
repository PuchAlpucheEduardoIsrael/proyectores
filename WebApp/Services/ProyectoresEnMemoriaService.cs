using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresEnMemoriaService : IProyectoresService
    {
        private static List<Proyector> _proyectores = LoadData();
        public void AddProyector(Proyector proyector)
        {
            if(proyector != null)
            {
                _proyectores.Add(proyector);
            }
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _proyectores;
        }

        public static List<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 2,
                Marca = "Hp",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Brother",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Canon",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Xerox",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });


            return proyectores;
        }

        public Proyector GetProyectorById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Proyector proyector)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Proyector? Delete(Proyector proyector)
        {
            throw new NotImplementedException();
        }
    }
}
