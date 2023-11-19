using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class TypeManager : GenericService<EntityLayer.Entities.Type>
    {
        ITypeRepository _typeRepository;

        public TypeManager(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public void Add(EntityLayer.Entities.Type p)
        {
            _typeRepository.Add(p);
        }

        public void Delete(EntityLayer.Entities.Type p)
        {
            _typeRepository.Delete(p);
        }

        public EntityLayer.Entities.Type GetById(int id)
        {
            return _typeRepository.GetById(id);
        }

        public List<EntityLayer.Entities.Type> List()
        {
            return _typeRepository.List();
        }

        public List<EntityLayer.Entities.Type> List(Expression<Func<EntityLayer.Entities.Type, bool>> filter)
        {
            return _typeRepository.List(filter);
        }

        public void Update(EntityLayer.Entities.Type p)
        {
            _typeRepository.Update(p);
        }
    }
}
