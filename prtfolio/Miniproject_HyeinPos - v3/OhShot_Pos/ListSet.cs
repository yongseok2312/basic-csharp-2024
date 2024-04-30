using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhShot_Pos
{
    class ListSet
    { 
        public void SetList(string TableNumber)
        {
            switch (TableNumber)
            {

                case "table1":
                    FoodTotalList.list = FoodTotalList.table1Menu;
                    break;
                case "table2":
                    FoodTotalList.list = FoodTotalList.table2Menu;
                    break;
                case "table3":
                    FoodTotalList.list = FoodTotalList.table3Menu;
                    break;
                case "table4":
                    FoodTotalList.list = FoodTotalList.table4Menu;
                    break;
                case "table5":
                    FoodTotalList.list = FoodTotalList.table5Menu;
                    break;
                case "table6":
                    FoodTotalList.list = FoodTotalList.table6Menu;
                    break;
            }
        }

        public void SetPgList(string TableNumber)
        {
            switch (TableNumber)
            {
                case "table1":
                    FoodTotalList.table1Menu = FoodTotalList.list;
                    break;
                case "table2":
                    FoodTotalList.table2Menu = FoodTotalList.list;
                    break;
                case "table3":
                    FoodTotalList.table3Menu = FoodTotalList.list;
                    break;
                case "table4":
                    FoodTotalList.table4Menu = FoodTotalList.list;
                    break;
                case "table5":
                    FoodTotalList.table5Menu = FoodTotalList.list;
                    break;
                case "table6":
                    FoodTotalList.table6Menu = FoodTotalList.list;
                    break;
            }
        }
    }
}