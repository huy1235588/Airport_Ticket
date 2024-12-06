using LeThienHuy.DTO;
using LeThienHuy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeThienHuy
{
    public partial class BookingConfirmForm : Form
    {
        int numberPassenger;
        decimal totalAmount;

        public BookingConfirmForm(FlightScheduleDTO OutboundDetails,
                    FlightScheduleDTO ReuturnDetails = null,
                    int NumberPassenger = 0)
        {
            InitializeComponent();
            // Tải dữ liệu chuyến bay đi từ Form Search Flight
            lblFromOutbound.Text = OutboundDetails.From;
            lblToOutbound.Text = OutboundDetails.To;
            lblCabinTypeOutbound.Text = OutboundDetails.CabinType;
            lblDateOutbound.Text = OutboundDetails.Date.ToShortDateString();
            lblFlightNumberOutbound.Text = OutboundDetails.FlightNumber;

            // Tải dữ liệu chuyến bay đi về
            if (ReuturnDetails == null)
            {
                gbReturnDetails.Visible = false;
            }
            else
            {
                lblFromReturn.Text = ReuturnDetails.From;
                lblToReturn.Text = ReuturnDetails.To;
                lblCabinTypeReturn.Text = ReuturnDetails.CabinType;
                lblDateReturn.Text = ReuturnDetails.Date.ToShortDateString();
                lblFlightNumberReturn.Text = ReuturnDetails.FlightNumber;
            }

            // Số lượng hành khách
            numberPassenger = NumberPassenger;
            // Giá tiền
            decimal returnPrice = (ReuturnDetails != null)
                ? ReuturnDetails.CabinPrice * numberPassenger
                : 0;

            totalAmount = numberPassenger * OutboundDetails.CabinPrice + returnPrice;
        }

        // Khởi tạo context
        FlightContextDB db = new FlightContextDB();

        private void BookingConfirmForm_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu country
            List<Country> countries = db.Countries.ToList();

            // Load dữ liệu lên comboBox
            cmbPassportCountry.DataSource = countries;
            cmbPassportCountry.DisplayMember = "Name";
            cmbPassportCountry.ValueMember = "ID";

            // Mặc định không chọn
            cmbPassportCountry.SelectedIndex = -1;
        }

        // Quay về form cữ
        private void btnBackForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Nút thêm hành khách
        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            if (dgvPassenger.Rows.Count >= numberPassenger)
            {
                return;
            }

            // Kiểm tra đủ thông tin
            if (txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtPassportNumber.Text == "" ||
                cmbPassportCountry.Text == "" ||
                txtPhone.Text == ""
                )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return;
            }

            int index = dgvPassenger.Rows.Add();
            dgvPassenger.Rows[index].Cells[0].Value = txtFirstName.Text;
            dgvPassenger.Rows[index].Cells[1].Value = txtLastName.Text;
            dgvPassenger.Rows[index].Cells[2].Value = dtpBirthDay.Text;
            dgvPassenger.Rows[index].Cells[3].Value = txtPassportNumber.Text;
            dgvPassenger.Rows[index].Cells[4].Value = cmbPassportCountry.Text;
            dgvPassenger.Rows[index].Cells[5].Value = txtPhone.Text;
        }

        // Nút xóa hành khách
        private void btnRemovePassenger_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn dòng
            if (dgvPassenger.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo");
                return;
            }

            foreach (DataGridViewRow item in dgvPassenger.SelectedRows)
            {
                dgvPassenger.Rows.Remove(item);
            }
        }

        // Nút xác nhận
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Kiểm tra đủ lượng khách hàng
            if (dgvPassenger.Rows.Count != numberPassenger)
            {
                MessageBox.Show("Vui lòng nhập đủ lượng khách hàng", "Thông báo");
                return;
            }

            BillingConfirmationForm billingConfirmationForm = 
                new BillingConfirmationForm(totalAmount);
            this.Hide();
            billingConfirmationForm.ShowDialog();
            this.Show();
        }
    }
}
