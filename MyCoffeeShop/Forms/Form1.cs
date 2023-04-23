using MyCoffeeShop.DAO;
using MyCoffeeShop.DTO;
using MyCoffeeShop.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyCoffeeShop
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

            LoadShift();
        }

        #region Events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (cbRemember.Checked)
            {
                Properties.Settings.Default.Username = tbUsername.Text;
                Properties.Settings.Default.Password = tbPassword.Text;
                Properties.Settings.Default.Save();
            }

            if (Login(username, password))
            {
                int staff_id = GetIdByUsername(username);
                int shift_id = (cbbShift.SelectedItem as Shift).Id;

                if (staff_id != 0)
                {
                    if (!isAdmin(staff_id))
                    {
                        Shift shift = cbbShift.SelectedItem as Shift;
                        TimeSpan from = shift.Opening_time;
                        TimeSpan to = shift.Closing_time;

                        if (LoginTime(from, to))
                        {
                            Insert(staff_id, shift_id);
                            this.Hide();
                            fPos fPos = new fPos();
                            fPos.ShowDialog();
                            this.Show();
                        }
                        else
                            MessageBox.Show(shift.Name + " bắt đầu từ: " + shift.Opening_time + "" +
                                " và kết thúc lúc: " + shift.Closing_time +
                                "\nVui lòng chọn đúng ca làm việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                    else
                    {
                        Insert(staff_id, shift_id);
                        this.Hide();
                        fAdmin fAdmin = new fAdmin();
                        fAdmin.ShowDialog();
                        this.Show();
                    }
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
                MessageBox.Show("Vui lòng nhập đúng tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                tbUsername.Text = Properties.Settings.Default.Username;
                tbPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void tbPassword_IconRightClick(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.PasswordChar = default;
                tbPassword.IconRight = Image.FromFile(Application.StartupPath + @"/Image/show.png");
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.IconRight = Image.FromFile(Application.StartupPath + @"/Image/hide.png");
            }
        }
        #endregion

        #region Methods
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        int GetIdByUsername(string username)
        {
            return AccountDAO.Instance.GetIdByUsername(username);
        }

        bool isAdmin(int staff_id)
        {
            return AccountDAO.Instance.isAdmin(staff_id);
        }

        void LoadShift()
        {
            cbbShift.DataSource = ShiftDAO.Instance.GetShiftList();
            cbbShift.DisplayMember = "name";
        }

        void Insert(int staff_id, int shift_id)
        {
            WorkingDAO.Instance.Insert(staff_id, shift_id);
        }

        bool LoginTime(TimeSpan from, TimeSpan to)
        {
            TimeSpan now = DateTime.Now.TimeOfDay;

            if (now >= from && now <= to)
                return true;
            return false;
        }
        #endregion
    }
}
