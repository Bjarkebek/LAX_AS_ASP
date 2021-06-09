using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAX_AS_ASP.Controllers
{
    public class HomeController : Controller
    {
        public class Film
        {
            public string FilmTitel { get; set; }
            public string FilmInstruk { get; set; }
            public string FilmUdgiv { get; set; }
            public string FilmOm { get; set; }
            public string FilmNomi { get; set; }
            public string NomiVundet { get; set; }
        }

        public ActionResult Index()
        {

            SqlConnection cnn = new SqlConnection("Data Source=10.0.5.102,1433;Initial Catalog=LAX_DB;User ID=sa; Password=Guest1234");
            string sql = "SELECT * FROM Film WHERE FilmNomi = NOT NULL ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader rdr;
            string Output = "";

            //var model = new List<Film>();

            using (cnn)
            {
                cnn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Output = Output + rdr.GetValue(0);

                    //    var Film = new Film();
                    //    Film.FilmTitel = rdr["FilmTitel"];
                    //    Film.FilmInstruk = rdr["FilmInstruk"];
                    //    Film.FilmUdgiv = rdr["FilmUdgiv"];
                    //    Film.FilmOm = rdr["FilmOm"];
                    //    Film.FilmNomi = rdr["FilmNomi"];
                    //    Film.NomiVundet = rdr["NomiVundet"];

                    //    model.Add(Film);
                    //}
                }
            }


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}