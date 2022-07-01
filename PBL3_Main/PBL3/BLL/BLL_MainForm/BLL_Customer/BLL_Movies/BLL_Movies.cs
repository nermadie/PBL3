using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_View;
using PBL3.DTO.DTO_ShowTime;
using PBL3.EntityFramework;

namespace PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Movies
{
    public class BLL_Movies
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_Movies _Instance;

        public static BLL_Movies Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Movies();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_Movies()
        {
        }

        public List<Movie> getMovies(string text, string sortBy, string category)
        {
            var listAllMovie = db.Movies.ToList();
            if (sortBy == "Latest" && category == "All")
                return listAllMovie.Where(m => m.NameMovie.ToLower().Contains(text.ToLower())).OrderByDescending(m => m.ReleaseDate).ToList();
            if (sortBy == "Latest" && category != "All")
                return listAllMovie.Where(m => m.NameMovie.ToLower().Contains(text.ToLower()) && m.Category.Contains(category)).OrderByDescending(m => m.ReleaseDate).ToList();
            if (sortBy == "Popular" && category != "All")
                return listAllMovie.Where(m => m.NameMovie.ToLower().Contains(text.ToLower()) && m.Category.Contains(category)).OrderByDescending(m => m.Rate).ToList();
            if (sortBy == "Popular" && category == "All")
                return listAllMovie.Where(m => m.NameMovie.ToLower().Contains(text.ToLower())).OrderByDescending(m => m.Rate).ToList();
            throw new Exception("Wrong");
        }

        public CBBItem[] getCBBCategory()
        {
            List<string> categories = new List<string>();
            var category_strings = db.Movies.Select(m => m.Category).ToList();
            string[] separatingStrings = { ", " };
            foreach (string category_string in category_strings)
                categories.AddRange(category_string.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries));
            List<CBBItem> res = new List<CBBItem>();
            categories = categories.Distinct().ToList();
            res.Add(new CBBItem
            {
                Text = "All",
                Value = 0
            });
            for (int i = 1; i <= categories.Count; i++)
                res.Add(new CBBItem
                {
                    Text = categories[i - 1],
                    Value = i
                });
            return res.ToArray();
        }
    }
}
