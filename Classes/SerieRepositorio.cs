using System;
using System.Collections.Generic;
using System.Linq;

namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie> {
        private IDictionary<int, Serie> _listaSerie = new Dictionary<int, Serie>();
        public void Atualiza(int id, Serie entidade) => _listaSerie[id] = entidade;
        
        public void Exclui(int id) => _listaSerie[id].Excluir();
        
        public void Insere(Serie entidade, int id) => _listaSerie.Add(id, entidade);

        public List<Serie> Lista() => _listaSerie.Values.ToList();

        public int ProximoId() => _listaSerie.Count;
        
        public Serie RetornaPorId(int id) => _listaSerie[id];
    }
}