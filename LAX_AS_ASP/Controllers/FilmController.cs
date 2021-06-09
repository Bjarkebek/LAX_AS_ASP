using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAX_AS_ASP.Models;

namespace LAX_AS_ASP.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Index()
        {
            List<FilmDB> Film = new List<FilmDB>();

            SqlConnection cnn = new SqlConnection("Data Source=10.0.5.102,1433;Initial Catalog=LAX_DB;User ID=sa; Password=Guest1234");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Film", cnn);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr[5] != null)
                    Film.Add(new FilmDB() { FilmID = Convert.ToInt32(dr[0]), FilmTitel = dr[1].ToString(), FilmInstruk = dr[2].ToString(), FilmUdgiv = Convert.ToInt32(dr[3]), FilmOm = dr[4].ToString(), FilmNomi = dr[5].ToString(), NomiVundet = Convert.ToInt32(dr[6]) });

            }
            return View();
        }
    }
}