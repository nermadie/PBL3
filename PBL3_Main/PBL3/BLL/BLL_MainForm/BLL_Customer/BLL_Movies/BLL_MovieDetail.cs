using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_ShowTime;
using PBL3.EntityFramework;

namespace PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Movies
{
    public class BLL_MovieDetail
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_MovieDetail _Instance;

        public static BLL_MovieDetail Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_MovieDetail();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_MovieDetail()
        {
        }

        public Movie getMoviebyIdMovie(string idMovie)
        {
            return db.Movies.FirstOrDefault(m => m.IdMovie == idMovie);
        }
    }
}
