using MyCoffeeShop.DTO;
using System;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class InvoiceDAO
    {
        private static InvoiceDAO instance;

        public static InvoiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new InvoiceDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private InvoiceDAO() { }

        #region Pos
        public int GetUnpaidInvoiceId(int table_id, int shift_id)
        {
            string query = "EXEC dbo.USP_GetUnpaidInvoiceId @table_id , @shift_id";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { table_id, shift_id });

            if (dt.Rows.Count > 0)
            {
                Invoice invoice = new Invoice(dt.Rows[0]);
                return invoice.Id;
            }

            return -1;
        }

        public int GetMaxInvoiceId()
        {
            string query = "SELECT MAX(id) FROM dbo.Invoice";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public int CountUnpaidInvoice()
        {
            string query = "select count(*) from dbo.Invoice where status = 0";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        #endregion

        #region Admin
        public DataTable GetInvoiceList()
        {
            string query = "EXEC dbo.USP_GetInvoiceList";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetInvoiceList(DateTime from, DateTime to)
        {
            string query = "EXEC dbo.USP_GetInvoiceListByDates @from , @to";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });
        }

        public DataTable GetInvoiceList(DateTime created_date)
        {
            string query = "EXEC dbo.USP_GetInvoiceListByDate @created_date";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { created_date });
        }

        public DataTable GetInvoiceList(int shift_id)
        {
            string query = "EXEC dbo.USP_GetInvoiceByShift @shift_id";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { shift_id });
        }

        public void Insert(int table_id, int shift_id)
        {
            string query = "EXEC dbo.USP_InsertInvoice @table_id , @shift_id";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { table_id, shift_id });
        }

        public void Update(int invoice_id, int total_quantity, float total_price, float discount_price, string staff_name)
        {
            string query = "EXEC dbo.USP_UpdateInvoice @invoice_id , @total_quantity , @total_price , @discount_price , @staff_name";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { invoice_id, total_quantity, total_price, discount_price, staff_name });
        }

        public void Delete(int invoice_id)
        {
            string query = "EXEC dbo.USP_DeleteInvoice @invoice_id";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { invoice_id });
        }
        #endregion

    }
}
