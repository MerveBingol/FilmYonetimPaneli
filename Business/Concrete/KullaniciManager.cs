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
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }
        public void AddKulllanici(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);
        }

        public void DeleteKullanici(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }

        public Kullanici GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateKullanici(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }
    }
}
