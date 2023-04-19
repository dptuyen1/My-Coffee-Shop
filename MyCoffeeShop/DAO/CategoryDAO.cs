using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private CategoryDAO() { }

        public static int height = 100, width = 100;

        #region Admin

        public List<Category> GetCategoryList()
        {
            List<Category> categories = new List<Category>();

            string query = "select * from dbo.Category";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Category category = new Category(row);
                categories.Add(category);
            }

            return categories;
        }

        #endregion
    }
}
