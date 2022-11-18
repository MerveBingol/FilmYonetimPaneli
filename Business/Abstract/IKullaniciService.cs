using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public interface IKullaniciService
    {
        void AddKulllanici(Kullanici kullanici);
        void DeleteKullanici(Kullanici kullanici);
        void UpdateKullanici(Kullanici kullanici);
        List<Kullanici> GetList();
        Kullanici GetById(int id);
    }
}
