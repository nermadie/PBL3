using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO.DTO_PopcornDrink;
using PBL3.EntityFramework;
using PBL3.GUI.GUI_AdditionalUserControl.UC_PopcornDrinkItem;

namespace PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_PopcornDrink
{
    public class BLL_PopcornDrink
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_PopcornDrink _Instance;
        public static BLL_PopcornDrink Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PopcornDrink();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_PopcornDrink()
        {
        }

        public List<PopcornDrink> getListPopcornDrink()
        {
            return db.PopcornDrinks.ToList();
        }
        public Image getImagebyIdPopcornDrink(string idPopcornDrink)
        {
            return Image.FromFile(@"..\..\Image\Picture\PicturePopcornDrink\" + idPopcornDrink + ".jpg");
        }

        public PopcornDrink getPDbyidPD(string idPopcornDrink)
        {
            return db.PopcornDrinks.FirstOrDefault(pd => pd.IdPopcornDrink == idPopcornDrink);
        }
    }
}
