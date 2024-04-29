using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OhShot_Pos.FoodCategory;

namespace OhShot_Pos
{
    internal class FoodMenuInfo
    {
        public Foodcategory category = Foodcategory.none; //premium, bowl 등등
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                imagePath = SetImagePath(category, name);
            }
        }
        public int price = 0; //메뉴 가격
        public int cnt = 0; // 메뉴 주문 수량
        public string imagePath = string.Empty; //메뉴 이미지 링크
        public string barcodeString = string.Empty;

        //ImagePath 설정하고 return 해주는 함수
        public string SetImagePath(Foodcategory category, string name)
        {
            string path = string.Empty;
            string RootPath = "Resources/MenuList/";

            switch (category)
            {
                case Foodcategory.primeumGomei:
                    RootPath += "primeumGomei/";
                    break;

                case Foodcategory.square:
                    RootPath += "square/";
                    break;

                case Foodcategory.bowl:
                    RootPath += "bowl/";
                    break;

                case Foodcategory.side:
                    RootPath += "side/";
                    break;

                case Foodcategory.drink:
                    RootPath += "drink/";
                    break;

                default:
                    break;
            }

            path = RootPath + name + ".jpg";

            return path;
        }
    }
}
