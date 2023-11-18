using DataAccesLayer.Data;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class EfGenericSettingRepository : GenericRepository<GeneralSettings, DataContext>, IGeneralSettingsRepository
    {
        private DataContext context;

        public EfGenericSettingRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

    }
}
