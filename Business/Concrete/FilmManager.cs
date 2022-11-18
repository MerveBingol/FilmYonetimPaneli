using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FilmManager : IFilmService
    {
        IFilmDal _filmDal;

        public FilmManager(IFilmDal filmDal) 
        {
            _filmDal = filmDal;
        }
        public void AddFilm(Film film)
        {
            _filmDal.Add(film);
        }

        public void DeleteFilm(Film film)
        {
            _filmDal.Delete(film);
        }

        public Film GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Film> GetList()
        {
            return _filmDal.GetAll();
        }

        public void UpdateFilm(Film film)
        {
            throw new NotImplementedException();
        }
    }
}
