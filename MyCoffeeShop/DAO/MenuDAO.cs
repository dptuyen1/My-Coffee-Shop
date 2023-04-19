using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetMenuItem(int table_id, int shift_id)
        {
            List<Menu> items = new List<Menu>();

            string query = "EXEC dbo.USP_GetMenuItem @table_id , @shift_id";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { table_id, shift_id });

            foreach (DataRow row in data.Rows)
            {
                Menu item = new Menu(row);
                items.Add(item);
            }

            return items;
        }
    }
}
