using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class FeaturedManager : IFeaturedService
    {
        IFeatureDal _featureDal;

        public FeaturedManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TDelete(Featured t)
        {
            throw new NotImplementedException();
        }

        public Featured TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Featured> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TInsert(Featured t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Featured t)
        {
            throw new NotImplementedException();
        }
    }
}
