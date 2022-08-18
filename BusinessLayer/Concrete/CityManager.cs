using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CityManager : ICityService

    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        
        public void CityAdd(City city)
        {
            _cityDal.Insert(city);
        }

        public void CityDelete(City city)
        {
            _cityDal.Delete(city);
        }

        public void CityUpdate(City city)
        {
            _cityDal.Update(city);
        }

        public City GetById(int id)
        {
            return _cityDal.GetByID(id);
        }

        public List<City> GetList()
        {
            return _cityDal.GetListAll();
        }
    }
}
