using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAX_AS_ASP.Models
{
    public class FilmDB
    {
        public int FilmID { get; set; }
        public string FilmTitel { get; set; }
        public string FilmInstruk { get; set; }
        public int FilmUdgiv { get; set; }
        public string FilmOm { get; set; }
        public string FilmNomi { get; set; }
        public int NomiVundet { get; set; }
    }
}