using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfFilmDal : EfEntityRepositoryBase<Film, Context>, IFilmDal
    {
        public List<FilmDetailDto> GetFilmDetails()
        {
            using (Context context = new Context())
            {
                var result = from f in context.Filmler
                             join s in context.Salonlar
                             on f.SalonID equals s.SalonID
                             select new FilmDetailDto
                             {
                                 SalonID = s.SalonID,


                             };

                return result.ToList();
            }
        }
    }
}
