using LeThienHuy.DTO;
using LeThienHuy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeThienHuy
{
    public partial class SearchFlightForm : Form
    {
        public SearchFlightForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Phương thức gán dữ liệu vào comboBox
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="comboBox">ComboBox cần gán</param>
        /// <param name="dataSource">Dữ liệu gán</param>
        /// <param name="DisplayMember">Thuộc tính hiển thị</param>
        /// <param name="ValueMember">Thuộc tính giá trị</param>
        private void setDataComboBox<T>(ComboBox comboBox,
            List<T> dataSource,
            string DisplayMember,
            string ValueMember
            )
        {
            // Xóa dữ liệu cũ
            comboBox.Items.Clear();

            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = DisplayMember;
            comboBox.ValueMember = ValueMember;
        }

        // Khởi tạo ContextDB
        FlightContextDB db = new FlightContextDB();

        private void SearchFlightForm_Load(object sender, EventArgs e)
        {
            // Lấy danh sách airport
            List<Airport> airportForm = db.Airports.ToList();
            // Gán vào comboBox From
            setDataComboBox(cmbFrom, airportForm, "IATACode", "ID");
            cmbFrom.SelectedIndex = -1;

            // Lấy danh sách airport
            List<Airport> airportTo = db.Airports.ToList();
            // Gán vào comboBox To
            setDataComboBox(cmbTo, airportTo, "IATACode", "ID");
            cmbTo.SelectedIndex = -1;

            // Lấy danh sách Cabin type
            List<CabinType> cabinTypes = db.CabinTypes.ToList();
            // Gán vào comboBox From
            setDataComboBox(cmbCabinType, cabinTypes, "Name", "ID");
            cmbCabinType.SelectedValue = cabinTypes[0].ID;

            // Mặc định chọn Return
            radReturn.Checked = true;

            // Không cho chọn ngày đến sau ngày đi
            dtpReturn.MinDate = dtpOutbound.Value;
        }

        private void radReturn_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu chọn return sẽ hiển thị
            lblReturn.Visible = radReturn.Checked;
            dtpReturn.Visible = radReturn.Checked;
            dgvReturnDetails.Visible = radReturn.Checked;
            lblReturnDetails.Visible = radReturn.Checked;
            chkReturn.Visible = radReturn.Checked;
        }

        /// <summary>
        /// Phương thức tải dữ liệu lên DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView cần tải dữ liệu</param>
        /// <param name="flightSchedules">Danh sách dữ liệu</param>
        private void showDgv(DataGridView dgv, List<FlightScheduleDTO> flightSchedules)
        {
            // Xóa dữ liệu cũ
            dgv.Rows.Clear();

            foreach (FlightScheduleDTO data in flightSchedules)
            {
                int index = dgv.Rows.Add();

                dgv.Rows[index].Cells[0].Value = data.From;
                dgv.Rows[index].Cells[1].Value = data.To;
                dgv.Rows[index].Cells[2].Value = data.Date;
                dgv.Rows[index].Cells[3].Value = data.Time;
                dgv.Rows[index].Cells[4].Value = data.FlightNumber;
                dgv.Rows[index].Cells[5].Value = data.CabinPrice;
                dgv.Rows[index].Cells[7].Value = data.Id;
                dgv.Rows[index].Cells[8].Value = cmbCabinType.Text;
            }
        }

        /// <summary>
        /// Phương thức truy vấn lịch trình
        /// </summary>
        /// <param name="fromId">Địa điểm đi</param>
        /// <param name="toId">Địa điểm đến</param>
        /// <param name="Date">Ngày khởi hành</param>
        /// <returns></returns>
        private List<FlightScheduleDTO> querySchedule(int fromId, int toId, DateTime Date)
        {
            // Phạm vi ngày
            DateTime startDate = Date.AddDays(-3);
            DateTime endDate = Date.AddDays(3);

            return (from s in db.Schedules
                    join r in db.Routes on s.RouteID equals r.ID
                    join ad in db.Airports on r.DepartureAirportID equals ad.ID
                    join aa in db.Airports on r.ArrivalAirportID equals aa.ID
                    where ad.ID == fromId &&
                        aa.ID == toId &&
                        s.Date >= startDate &&
                        s.Date <= endDate
                    select new FlightScheduleDTO
                    {
                        Id = s.ID,
                        From = ad.IATACode,
                        To = aa.IATACode,
                        Date = s.Date,
                        Time = s.Time,
                        FlightNumber = s.FlightNumber,
                        CabinPrice = cmbCabinType.Text == "Economy" ?
                            s.EconomyPrice // Economy
                            : cmbCabinType.Text == "Business"
                                ? Math.Floor(s.EconomyPrice * (decimal)1.35) // Business
                                : Math.Floor(s.EconomyPrice * (decimal)1.35 * (decimal)1.3) // First Class
                    }).ToList();
        }

        // Xử lý nhấn nút Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn sân bay
            if (cmbFrom.Text == "")
            {
                MessageBox.Show("Vui lòng chọn điểm đi", "Thông báo");
                return;
            }
            else if (cmbTo.Text == "")
            {
                MessageBox.Show("Vui lòng chọn điểm đến", "Thông báo");
                return;
            }

            // Lấy giá trị từ comboBox của from và to
            int fromId = int.Parse(cmbFrom.SelectedValue.ToString());
            int toId = int.Parse(cmbTo.SelectedValue.ToString());
            DateTime date = dtpOutbound.Value;

            // Lấy danh sách lịch trình đi
            List<FlightScheduleDTO> outboundDetails = querySchedule(fromId, toId, date);

            // Nếu chọn checkmark
            if (!chkOutbound.Checked)
            {
                outboundDetails = outboundDetails.Where(s => s.Date == date).ToList();
            }

            // Nếu chọn vé khứ hồi
            if (radReturn.Checked)
            {
                // Đảo ngược địa điểm
                List<FlightScheduleDTO> returnDetails = querySchedule(toId, fromId, date);

                // Nếu chọn checkmark
                if (!chkReturn.Checked)
                {
                    returnDetails = returnDetails.Where(s => s.Date == date).ToList();
                }

                // Hiển thị ra DGV return
                showDgv(dgvReturnDetails, returnDetails);
            }

            // Hiển thị ra DGV outbound
            showDgv(dgvOutboundDetails, outboundDetails);
        }

        // Khi thay đổi thời gian đi
        private void dtpOutbound_ValueChanged(object sender, EventArgs e)
        {
            // Không cho chọn ngày đến sau ngày đi
            dtpReturn.MinDate = dtpOutbound.Value;
        }

        // Khi chọn hiển thị 3 ngày trước hoặc sau
        private void chkOutbound_CheckedChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ comboBox của from và to
            int fromId = int.Parse(cmbFrom.SelectedValue.ToString());
            int toId = int.Parse(cmbTo.SelectedValue.ToString());
            DateTime date = dtpOutbound.Value;

            // Lấy danh sách lịch trình đi
            List<FlightScheduleDTO> outboundDetails = querySchedule(fromId, toId, date);

            if (!chkOutbound.Checked)
            {
                outboundDetails = outboundDetails.Where(s => s.Date == date).ToList();
            }

            showDgv(dgvOutboundDetails, outboundDetails);
        }

        private void chkReturn_CheckedChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ comboBox của from và to
            int fromId = int.Parse(cmbFrom.SelectedValue.ToString());
            int toId = int.Parse(cmbTo.SelectedValue.ToString());
            DateTime date = dtpOutbound.Value;

            // Lấy danh sách lịch trình đi
            List<FlightScheduleDTO> returnDetails = querySchedule(toId, fromId, date);

            if (!chkReturn.Checked)
            {
                returnDetails = returnDetails.Where(s => s.Date == date).ToList();
            }

            showDgv(dgvReturnDetails, returnDetails);
        }

        /// <summary>
        /// Phương thức kiểm tra ghế còn lại
        /// </summary>
        /// <param name="dgv">DataGridViewRow</param>
        /// <returns></returns>
        private bool checkSeat(DataGridViewRow dgv)
        {
            // Lấy id lịch trình đang chọn
            string scheduleId = dgv.Cells[7].Value.ToString();
            // Lấy cabin type
            string cabintype = dgv.Cells[8].Value.ToString();
            // Chuyển thành cabin type thành id
            int cabinTypeId = cabintype == "Economy" ? 1
                           : cabintype == "Business" ? 2
                           : 3;

            // Đếm số lượng ticket
            var query = db.Database.SqlQuery<SeatFlightDTO>($@"
                SELECT 
                    CASE t.CabinTypeID
                        WHEN 1 THEN EconomySeats
                        WHEN 2 THEN BusinessSeats
                        WHEN 3 THEN TotalSeats - EconomySeats - BusinessSeats
                    END AS TotalSeat, 
                    COUNT(*) AS BookedSeat
                FROM Schedules s 
                JOIN Tickets t ON s.ID = t.ScheduleID
                JOIN Aircrafts a ON s.AircraftID = a.ID
                WHERE s.ID = {scheduleId} AND CabinTypeID = {cabinTypeId}
                GROUP BY CabinTypeID, EconomySeats, BusinessSeats, TotalSeats
            ").First();

            return query.TotalSeat < query.BookedSeat + int.Parse(txtPassenger.Text);
        }

        /// <summary>
        /// Phương thức khởi tạo FlightScheduleDTO
        /// </summary>
        /// <param name="row">Hàng được chọn</param>
        /// <returns></returns>
        private FlightScheduleDTO createFlightScheduleDTO(DataGridViewRow row)
        {
            return new FlightScheduleDTO
            {
                From = row.Cells[0].Value.ToString(),
                To = row.Cells[1].Value.ToString(),
                CabinType = row.Cells[8].Value.ToString(),
                CabinPrice = decimal.Parse(row.Cells[5].Value.ToString()),
                Date = DateTime.Parse(row.Cells[2].Value.ToString()),
                FlightNumber = row.Cells[4].Value.ToString()
            };
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            // Kiểm tra lượng khách có rỗng
            if (txtPassenger.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Passengers", "Thông báo");
                return;
            }

            // Kiểm tra số nguyên dương
            if (!int.TryParse(txtPassenger.Text, out int passengerCount) ||
                passengerCount <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng Passengers hợp lý", "Thông báo");
                return;
            }

            // Kiểm tra đã chọn lịch trình
            if (dgvOutboundDetails.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn lịch trình", "Thông báo");
                return;
            }

            // Lấy dữ liệu được chọn (lịch trình đi)
            DataGridViewRow selectedRowOutbound = dgvOutboundDetails.SelectedRows[0];


            // Kiểm tra ghế trống cho chuyến đi
            if (checkSeat(selectedRowOutbound))
            {
                MessageBox.Show("Đã hết ghế đi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo thông tin chuyến đi
            FlightScheduleDTO outboundDetails = createFlightScheduleDTO(selectedRowOutbound);
            FlightScheduleDTO returnDetails = null;
            int numberPassenger = int.Parse(txtPassenger.Text);

            // Nếu chọn vé khứ hồi
            if (radReturn.Checked)
            {
                //  Kiểm tra đã chọn lịch trình về
                if (dgvReturnDetails.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Vui lòng chọn lịch trình về", "Thông báo");
                    return;
                }

                // Lấy dữ liệu hàng được chọn (Lịch trình về)
                DataGridViewRow selectedRowReturn = dgvReturnDetails.SelectedRows[0];

                // Kiểm tra ghế trống cho chuyến về
                if (checkSeat(selectedRowReturn))
                {
                    MessageBox.Show("Đã hết ghế về", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Khởi tạo thông tin chuyến về
                returnDetails = createFlightScheduleDTO(selectedRowReturn);
            }

            // Truyền dữ liệu sang form Confirm
            BookingConfirmForm bookingConfirmForm =
                new BookingConfirmForm(outboundDetails, returnDetails, numberPassenger);

            this.Hide();
            bookingConfirmForm.ShowDialog();
            this.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
