using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
  public class SalonManager:ISalonService
    {
        ISalonDal _salonDal;

        public SalonManager(ISalonDal salonDal)
        {
            _salonDal = salonDal;
        }

        public void AddFilm(Salon salon)
        {
            throw new NotImplementedException();
        }

        public void DeleteFilm(Salon salon)
        {
            throw new NotImplementedException();
        }

        public Salon GetById(int id)
        {
            throw new NotImplementedException();
        }


        public List<Salon> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateFilm(Salon salon)
        {
            throw new NotImplementedException();
        }
    }
}
