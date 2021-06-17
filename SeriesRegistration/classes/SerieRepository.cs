using System;
using System.Collections.Generic;
using SeriesRegistration.interfaces;

namespace SeriesRegistration
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();
        public List<Serie> List()
        {
            return listSerie;
        }
        public Serie ReturnsById(int id)
        {
            return listSerie[id];
        }
        public void Insert(Serie obj)
        {
            listSerie.Add(obj);
        }
        public void Delete(int id)
        {
            listSerie[id].Delete();
        }
        public void Update(int id, Serie obj)
        {
            listSerie[id] = obj;
        }
    }
}