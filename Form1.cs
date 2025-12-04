using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace BangGiaXe
{
    public partial class Form1 : Form
    {
        private DataUtils dataUtils = new DataUtils();
        private List<Card> cards = new List<Card>();
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            cards.Clear();
            cards = dataUtils.Show();
            dtgr_Card.DataSource = cards;
            dtgr_Card.Columns["HangXe"].HeaderText = "Hãng Xe";
            dtgr_Card.Columns["DongXe"].HeaderText = "Dòng Xe";
            dtgr_Card.Columns["PhienBan"].HeaderText = "Phiên Bản";
            dtgr_Card.Columns["DongCo"].HeaderText = "Động Cơ";
            dtgr_Card.Columns["Gia"].HeaderText = "Giá";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string hangxe = tb_hangxe.Text.Trim();
            string dongxe = tb_dongxe.Text.Trim();
            if(string.IsNullOrEmpty(hangxe) || string.IsNullOrEmpty(dongxe))
            {
                MessageBox.Show("Hãng xe và dòng xe là bắt buộc",
                    "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(dataUtils.checkAdd(hangxe, dongxe))
            {
                MessageBox.Show("Thông tin đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            Card card = new Card
            {
                HangXe = tb_hangxe.Text,
                DongXe = tb_dongxe.Text,
                PhienBan = tb_phienban.Text,
                DongCo = tb_dongco.Text,
                Gia = double.Parse(tb_gia.Text),
            };
            dataUtils.Add(card);
            LoadData();
            MessageBox.Show("Them moi thanh cong");
        }

        string oldhangXe = "";
        string olddongXe = "";

        private void dtgr_Card_SelectionChanged(object sender, EventArgs e)
        {
            if(dtgr_Card.CurrentRow == null) return;

            var row = dtgr_Card.CurrentRow;

            oldhangXe = row.Cells["HangXe"].Value?.ToString();
            olddongXe = row.Cells["DongXe"].Value?.ToString();

            tb_hangxe.Text = oldhangXe;
            tb_dongxe.Text = olddongXe;
            tb_phienban.Text = row.Cells["PhienBan"].Value?.ToString();
            tb_dongco.Text = row.Cells["DongCo"].Value?.ToString();
            tb_gia.Text = row.Cells["Gia"].Value?.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hangxe = tb_hangxe.Text.Trim();
            string dongxe = tb_dongxe.Text.Trim();
            if (string.IsNullOrEmpty(hangxe) || string.IsNullOrEmpty(dongxe))
            {
                MessageBox.Show("Hãng xe và dòng xe là bắt buộc",
                    "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Card card = new Card
            {
                HangXe = tb_hangxe.Text,
                DongXe = tb_dongxe.Text,
                PhienBan = tb_phienban.Text,
                DongCo = tb_dongco.Text,
                Gia = double.Parse(tb_gia.Text),
            };

            if (!dataUtils.Update(oldhangXe, olddongXe, card))
            {
                MessageBox.Show("Thông tin đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadData();
            MessageBox.Show("Cập nhật thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldhangXe) || string.IsNullOrEmpty(olddongXe))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            if (!dataUtils.Delete(oldhangXe, olddongXe))
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xóa!");
                return;
            }

            LoadData();
            MessageBox.Show("Đã xóa thành công!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string hangxe = tb_hangxe.Text.Trim();
            string dongxe = tb_dongxe.Text.Trim();

            List<Card> list = dataUtils.Search(hangxe, dongxe);

            dtgr_Card.DataSource = list;

            if (list.Count == 0)
                MessageBox.Show("Không tìm thấy kết quả!");
        }
    }
}
