
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
  public  class Film:IEntity
    {
        [Key]
        public int FilmID { get; set; }
        public string FilmAd { get; set; }
        public int FilmYapimYil { get; set; }
        public int SalonID { get; set; }
    }
}
