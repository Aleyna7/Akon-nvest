using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class NeighbourhoodManager : GenericService<Neighbourhood>
    {
        INeighbourhoodRepository _neigh;

        public NeighbourhoodManager(INeighbourhoodRepository neigh)
        {
            _neigh = neigh;
        }
        public void Add(Neighbourhood p)
        {
            _neigh.Add(p);
        }

        public void Delete(Neighbourhood p)
        {
            _neigh.Delete(p);
        }

        public Neighbourhood GetById(int id)
        {
            return _neigh.GetById(id);  
        }

        public List<Neighbourhood> List()
        {
            return _neigh.List();
        }

        public List<Neighbourhood> List(Expression<Func<Neighbourhood, bool>> filter)
        {
            return _neigh.List(filter);
        }

        public void Update(Neighbourhood p)
        {
            _neigh.Update(p);
        }
    }
}
