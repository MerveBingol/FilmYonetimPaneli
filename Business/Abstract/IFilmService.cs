using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface IFilmService
    {
        void AddFilm(Film film);
        void DeleteFilm(Film film);
        void UpdateFilm(Film film);
        List<Film> GetList();
        Film GetById(int id);
    }
}
