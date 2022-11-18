using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ISalonService
    {
        void AddFilm(Salon salon);
        void DeleteFilm(Salon salon);
        void UpdateFilm(Salon salon);
        List<Salon> GetList();
        Salon GetById(int id);
    }
}
