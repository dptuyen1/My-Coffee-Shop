using MyCoffeeShop.DAO;
using MyCoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace MyCoffeeShop.Forms
{
    public partial class fAdmin : Form
    {
        private static CultureInfo culture = new CultureInfo("vi-VN");

        private static int staff_id;

        private static string username;

        private static DateTime now = DateTime.Now;

        private static DateTime previous, next;

        public fAdmin()
        {
            InitializeComponent();

            Init();
        }

        #region Events
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Invoice
        private void btnStat_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;

            LoadInvoiceByDates(from, to);
        }

        private void btnLoadI_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = dtpTo.Value = DateTime.Now;
            cbbShift.DataSource = null;
            LoadInvoice();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            if (now != DateTime.Now)
                now = DateTime.Now;
            LoadInvoiceByDate(now);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            previous = now.AddDays(-1);
            LoadInvoiceByDate(previous);
            now = previous;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            next = now.AddDays(1);
            LoadInvoiceByDate(next);
            now = next;
        }

        private void cbbShift_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Shift shift = cbbShift.SelectedItem as Shift;
            int shift_id = shift.Id;

            LoadInvoiceByShift(shift_id);
        }

        private void cbbShift_DropDown(object sender, EventArgs e)
        {
            LoadShiftToCbb(cbbShift);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #endregion

        #region Methods
        void Init()
        {
            staff_id = GetStaffId();
            username = GetStaffName(staff_id);
            lbUsername.Text += username;
            dtpFrom.Value = dtpTo.Value = DateTime.Now;
            LoadResource();
            AddBinding();
        }

        void LoadResource()
        {
            LoadInvoice();
        }

        void AddBinding()
        {

        }

        void LoadShiftToCbb(ComboBox cb)
        {
            cb.DataSource = ShiftDAO.Instance.GetShiftList();
            cb.DisplayMember = "name";
        }

        void LoadInvoice()
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList();
        }

        void LoadInvoiceByDates(DateTime from, DateTime to)
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList(from, to);
        }

        void LoadInvoiceByDate(DateTime created_date)
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList(created_date);
        }

        void LoadInvoiceByShift(int shift_id)
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetInvoiceList(shift_id);
        }

        int GetStaffId()
        {
            List<Working> works = WorkingDAO.Instance.GetWorkingList();
            return works[0].Staff_id;
        }

        string GetStaffName(int id)
        {
            List<Staff> staffs = StaffDAO.Instance.GetStaffListById(id);
            return staffs[0].Name;
        }
        #endregion
    }
}
