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
    public class SituationManager : GenericService<Situation>
    {
        ISituationRepository _situationRepository;

        public SituationManager(ISituationRepository situationRepository)
        {
            _situationRepository = situationRepository;
        }
        public void Add(Situation p)
        {
            _situationRepository.Add(p);
        }

        public void Delete(Situation p)
        {
          _situationRepository.Delete(p);
        }

        public Situation GetById(int id)
        {
            return _situationRepository.GetById(id);
        }

        public List<Situation> List()
        {
            return _situationRepository.List();
        }

        public List<Situation> List(Expression<Func<Situation, bool>> filter)
        {
            return _situationRepository.List(filter);
        }

        public void Update(Situation p)
        {
           _situationRepository.Update(p);
        }
    }
}
