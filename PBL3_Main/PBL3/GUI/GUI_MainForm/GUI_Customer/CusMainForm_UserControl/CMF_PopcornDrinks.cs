using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_PopcornDrink;
using PBL3.DTO.DTO_PopcornDrink;
using PBL3.GUI.GUI_AdditionalUserControl.UC_CartPopcornDrink;
using PBL3.GUI.GUI_AdditionalUserControl.UC_PopcornDrinkItem;

namespace PBL3.GUI.GUI_MainForm.GUI_Customer.CusMainForm_UserControl
{
    public partial class CMF_PopcornDrinks : UserControl
    {
        private List<CartPopcornDrink> listCartPopcornDrink;
        private List<PopcornDrinkItem> listPopcornDrinkItem;
        public CMF_PopcornDrinks()
        {
            InitializeComponent();
            listCartPopcornDrink = new List<CartPopcornDrink>();
            listPopcornDrinkItem = new List<PopcornDrinkItem>();
        }

        private void CMF_PopcornDrinks_Load(object sender, EventArgs e)
        {
            listCartPopcornDrink = new List<CartPopcornDrink>();
            List<PopcornDrink> popcornDrinks = BLL_PopcornDrink.Instance.getListPopcornDrink();
            foreach (var popcornDrink in popcornDrinks)
            {
                PopcornDrinkItem temp = new PopcornDrinkItem(popcornDrink.IdPopcornDrink);
                temp.TitleText = popcornDrink.NamePopcornDrink;
                temp.PriceText = popcornDrink.PricePopcornDrink.ToString();
                temp.PosterImage = BLL_PopcornDrink.Instance.getImagebyIdPopcornDrink(popcornDrink.IdPopcornDrink);
                temp.add_removeCart = add_removeCart;
                listPopcornDrinkItem.Add(temp);
            }
            flowLayoutPanelItem.Controls.AddRange(listPopcornDrinkItem.ToArray());
        }
        private void add_removeCart(string idPopcornDrink, bool isAdd)
        {
            if (isAdd)
            {
                PopcornDrink popcornDrink = BLL_PopcornDrink.Instance.getPDbyidPD(idPopcornDrink);
                CartPopcornDrink temp = new CartPopcornDrink(popcornDrink.IdPopcornDrink);
                temp.add_removeCart = add_removeCart;
                temp.updateTotal = updateTotal;
                temp.TitleText = popcornDrink.NamePopcornDrink;
                temp.PriceText = popcornDrink.PricePopcornDrink.ToString();
                temp.Quantity = 1;
                listCartPopcornDrink.Add(temp);
                flowLayoutPanelChose.Controls.Add(temp);
            }
            else
            {
                PopcornDrink popcornDrink = BLL_PopcornDrink.Instance.getPDbyidPD(idPopcornDrink);
                listCartPopcornDrink = listCartPopcornDrink
                    .Where(cpd => cpd.currentPopcornDrink != popcornDrink.IdPopcornDrink).ToList();
                flowLayoutPanelChose.Controls.Clear();
                flowLayoutPanelChose.Controls.AddRange(listCartPopcornDrink.ToArray());
                PopcornDrinkItem temp =
                    listPopcornDrinkItem.FirstOrDefault(pdi => pdi.currentIdPopcornDrink == idPopcornDrink);
                temp.disableButtonTick();
            }
            updateTotal();
        }

        private void updateTotal()
        {
            int Total = 0;
            foreach (var cartPopcornDrink in listCartPopcornDrink)
            {
                Total += Convert.ToInt32(cartPopcornDrink.PriceText) * Convert.ToInt32(cartPopcornDrink.Quantity);
            }

            textBoxTotal.Text = Total.ToString();
        }
    }
}
