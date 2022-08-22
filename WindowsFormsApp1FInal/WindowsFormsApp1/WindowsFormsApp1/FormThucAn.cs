using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormThucAn : Form
    {
        int count;
        int price;
        //DataTable foodChosen;
        public FormThucAn()
        {
            InitializeComponent();
        }
        DataTable foodList;
        private void FormThucAn_Load(object sender, EventArgs e)
        {
            KhoiTao();
            getFoodList();
            for (int i = 0; i < foodList.Rows.Count; i++)
                this.flpFood.Controls.Add(createFoodItem(foodList.Rows[i][0].ToString(), foodList.Rows[i][1].ToString(), foodList.Rows[i][2].ToString(),
                    foodList.Rows[i][3].ToString(), foodList.Rows[i][4].ToString()));
        }
        private void getFoodList()
        {
            string query = "SELECT * FROM food";
            foodList = ConnectFun.RunQuery(query);
        }
        private void KhoiTao()
        {
            count = 0;
            price = 0;
            
            this.flpFood.Enabled = true;
            //foodChosen = new DataTable();
            //foodChosen.Columns.Add("Food Name");
            //foodChosen.Columns.Add("Quantity");
            this.foodPrice.Text = "0đ";
            this.foodCounter.Text = count.ToString();
            //
            this.flpCTHD.Controls.Clear();
        }

        string path = Application.StartupPath + @"\Resource\food\";
        private Panel createFoodItem(string foodId, string foodName, string desc, string unitPrice, string foodIcon)
        {
            Panel foodItem = new Panel();
            foodItem.Size = new System.Drawing.Size(270, 273);
            foodItem.BackColor = Color.FromArgb(198, 226, 255);
            foodItem.Name = foodItem + foodId;
            foodItem.Padding = new Padding(0, 0, 0, 60);
            foodItem.Margin = new Padding(10);
            //
            Label lbFoodName = new Label();
            lbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbFoodName.Location = new System.Drawing.Point(60, 175);
            lbFoodName.Name = "itemName";
            lbFoodName.Size = new System.Drawing.Size(209, 38);
            lbFoodName.TabIndex = 1;
            lbFoodName.Text = foodName;
            //
            Label lbDesc = new Label();
            lbDesc.Location = new System.Drawing.Point(6, 210);
            lbDesc.Name = "desc";
            lbDesc.Size = new System.Drawing.Size(200, 20);
            lbDesc.TabIndex = 4;
            lbDesc.Text = desc;
            //
            Label lbPrice = new Label();
            lbPrice.Location = new System.Drawing.Point(3, 247);
            lbPrice.Name = "price";
            lbPrice.Size = new System.Drawing.Size(89, 23);
            lbPrice.TabIndex = 2;
            lbPrice.ForeColor = Color.Red;
            lbPrice.Text = string.Format("{0:#,##}", int.Parse(unitPrice.ToString())) + "đ";
            //
            PictureBox imageItem = new PictureBox();
            imageItem.Dock = DockStyle.Top;
            imageItem.Location = new System.Drawing.Point(30, 4);
            imageItem.Name = "imageItem";
            imageItem.Size = new System.Drawing.Size(210, 170);
            imageItem.TabIndex = 0;
            imageItem.TabStop = false;
            imageItem.Image = Image.FromFile(path + foodIcon);
            imageItem.SizeMode = PictureBoxSizeMode.StretchImage;
            //
            Button addBtn = new Button();
            addBtn.Location = new System.Drawing.Point(235, 247);
            addBtn.Name = foodId;
            addBtn.Size = new System.Drawing.Size(30, 23);
            addBtn.TabIndex = 3;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += AddBtn_Click;
            //
            foodItem.Controls.Add(addBtn);
            foodItem.Controls.Add(lbFoodName);
            foodItem.Controls.Add(lbDesc);
            foodItem.Controls.Add(lbPrice);
            foodItem.Controls.Add(imageItem);

            return foodItem;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            count++;
            this.foodCounter.Text = count.ToString();
            for (int i = 0; i < foodList.Rows.Count; i++)
            {
                if (btn.Name == foodList.Rows[i][0].ToString())
                {
                    price += int.Parse(foodList.Rows[i][3].ToString());
                    this.foodPrice.Text = string.Format("{0:#,##}", price) + "đ";
                    Control ctrl = flpCTHD.Controls.Find("pnSP" + foodList.Rows[i][0], false).FirstOrDefault();
                    if (ctrl != null)
                    {
                        Panel foodPn = (Panel)ctrl;
                        TextBox foodNumber = ctrl.Controls.Find("foodNumber", false).FirstOrDefault() as TextBox;
                        foodNumber.Text = (int.Parse(foodNumber.Text) + 1).ToString();
                    }
                    else
                    {
                        this.flpCTHD.Controls.Add(createFoodChoicePanel(foodList.Rows[i][0].ToString(), foodList.Rows[i][1].ToString(), foodList.Rows[i][2].ToString(),
                        foodList.Rows[i][3].ToString(), foodList.Rows[i][4].ToString()));
                    }
                }
            }
        }
        private Panel createFoodChoicePanel(string foodId, string foodName, string desc, string unitPrice, string foodIcon)
        {
            Panel pnSP = new Panel();
            pnSP.BackColor = Color.FromArgb(198, 226, 255);
            pnSP.Location = new System.Drawing.Point(3, 3);
            pnSP.Name = "pnSP" + foodId;
            pnSP.Size = new System.Drawing.Size(600, 100);
            pnSP.TabIndex = 0;
            //
            PictureBox picSP = new PictureBox();
            picSP.Location = new System.Drawing.Point(0, 0);
            picSP.Name = "picSP";
            picSP.Size = new System.Drawing.Size(121, 100);
            picSP.TabIndex = 0;
            picSP.TabStop = false;
            picSP.Image = Image.FromFile(path + foodIcon);
            picSP.SizeMode = PictureBoxSizeMode.StretchImage;
            //
            Label lbFoodName = new Label();
            lbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbFoodName.Location = new System.Drawing.Point(127, 3);
            lbFoodName.Name = "foodNameChosen";
            lbFoodName.Size = new System.Drawing.Size(351, 23);
            lbFoodName.TabIndex = 1;
            lbFoodName.Text = foodName;
            // 
            // btnRemoveAll
            // 
            Button btnRemoveAll = new Button();
            btnRemoveAll.Location = new System.Drawing.Point(563, 0);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new System.Drawing.Size(36, 23);
            btnRemoveAll.TabIndex = 5;
            btnRemoveAll.Text = "x";
            btnRemoveAll.BackColor = Color.Red;
            btnRemoveAll.Margin = new Padding(0);
            btnRemoveAll.Click += BtnRemoveAll_Click;
            //btnDelete.UseVisualStyleBackColor = true;
            //
            // btnDelete
            //
            Button btnDelete = new Button();
            btnDelete.Location = new System.Drawing.Point(493, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(32, 23);
            btnDelete.Text = "-";
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Margin = new Padding(0);
            btnDelete.Click += BtnDelete_Click;
            //
            // btnAdd
            //
            Button btnAdd = new Button();
            btnAdd.Location = new System.Drawing.Point(563, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(32, 23);
            btnAdd.Text = "+";
            btnAdd.BackColor = Color.Yellow;
            btnAdd.Margin = new Padding(0);
            btnAdd.Click += BtnAdd_Click;
            // 
            // lbFoodDetail
            // 
            Label lbFoodDetail = new Label();
            lbFoodDetail.Location = new System.Drawing.Point(132, 33);
            lbFoodDetail.Name = "lbFoodDetail";
            lbFoodDetail.Size = new System.Drawing.Size(408, 23);
            lbFoodDetail.TabIndex = 6;
            lbFoodDetail.Text = desc;
            // 
            // lbFoodPrice
            // 
            Label lbFoodPrice = new Label();
            lbFoodPrice.Location = new System.Drawing.Point(132, 77);
            lbFoodPrice.Name = "lbFoodPrice";
            lbFoodPrice.Size = new System.Drawing.Size(100, 23);
            lbFoodPrice.TabIndex = 7;
            lbFoodPrice.Text = string.Format("{0:#,##}", unitPrice) + "đ";
            // 
            // foodNumber
            // 
            TextBox foodNumber = new TextBox();
            foodNumber.Location = new System.Drawing.Point(528, 71);
            foodNumber.Name = "foodNumber";
            foodNumber.Size = new System.Drawing.Size(32, 30);
            foodNumber.TabIndex = 8;
            foodNumber.Text = "1";
            foodNumber.Enabled = false;
            foodNumber.TextAlign = HorizontalAlignment.Center;
            //
            // foodPrice
            //
            Label fPrice = new Label();
            fPrice.Text = unitPrice;
            fPrice.Name = "fPrice";
            fPrice.Size = new Size(0, 0);
            fPrice.Visible = false;
            //
            pnSP.Controls.Add(foodNumber);
            pnSP.Controls.Add(lbFoodPrice);
            pnSP.Controls.Add(lbFoodDetail);
            pnSP.Controls.Add(btnRemoveAll);
            pnSP.Controls.Add(btnDelete);
            pnSP.Controls.Add(btnAdd);
            pnSP.Controls.Add(lbFoodName);
            pnSP.Controls.Add(picSP);
            pnSP.Controls.Add(fPrice);
            //
            return pnSP;

        }


        #region Sự Kiện Form Chi Tiết Hóa Đơn
        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (Panel panel in flpCTHD.Controls)
            {
                if (panel.Controls.Contains(btn))
                {
                    TextBox btnNumber = panel.Controls.Find("foodNumber", false).FirstOrDefault() as TextBox;
                    //
                    count -= int.Parse(btnNumber.Text);
                    this.foodCounter.Text = count.ToString();
                    Label label = panel.Controls.Find("fPrice", false).FirstOrDefault() as Label;
                    price -= int.Parse(label.Text) * int.Parse(btnNumber.Text);
                    this.foodPrice.Text = this.price == 0 ? "0đ" : string.Format("{0:#,##}", price) + "đ";
                    flpCTHD.Controls.Remove(panel);
                    //
                    break;
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (Panel panel in flpCTHD.Controls)
            {
                if (panel.Controls.Contains(btn))
                {
                    TextBox btnNumber = panel.Controls.Find("foodNumber", false).FirstOrDefault() as TextBox;
                    if (int.Parse(btnNumber.Text) > 1)
                    {
                        btnNumber.Text = (int.Parse(btnNumber.Text) - 1).ToString();
                        count--;
                        this.foodCounter.Text = count.ToString();
                        Label label = panel.Controls.Find("fPrice", false).FirstOrDefault() as Label;
                        price -= int.Parse(label.Text);
                        this.foodPrice.Text = string.Format("{0:#,##}", price) + "đ";
                    }
                    break;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (Panel panel in flpCTHD.Controls)
            {
                if (panel.Controls.Contains(btn))
                {
                    TextBox btnNumber = panel.Controls.Find("foodNumber", false).FirstOrDefault() as TextBox;
                    btnNumber.Text = (int.Parse(btnNumber.Text) + 1).ToString();
                    //
                    count++;
                    this.foodCounter.Text = count.ToString();
                    Label label = panel.Controls.Find("fPrice", false).FirstOrDefault() as Label;
                    price += int.Parse(label.Text);
                    this.foodPrice.Text = string.Format("{0:#,##}", price) + "đ";
                    //
                    break;
                }
            }
        }
        #endregion
        private void txtSearch_Click(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.txtSearch.Text;
            if (search != "")
            {
                this.flpFood.Controls.Clear();
                for (int i = 0; i < foodList.Rows.Count; i++)
                    if (foodList.Rows[i][1].ToString().IndexOf(search) != -1)
                    {
                        this.flpFood.Controls.Add(createFoodItem(foodList.Rows[i][0].ToString(), foodList.Rows[i][1].ToString(), foodList.Rows[i][2].ToString(),
                        foodList.Rows[i][3].ToString(), foodList.Rows[i][4].ToString()));
                    }
            }
            else
            {
                for (int i = 0; i < foodList.Rows.Count; i++)
                    this.flpFood.Controls.Add(createFoodItem(foodList.Rows[i][0].ToString(), foodList.Rows[i][1].ToString(), foodList.Rows[i][2].ToString(),
                            foodList.Rows[i][3].ToString(), foodList.Rows[i][4].ToString()));
            }
        }

        private void LapHoaDon(object sender, EventArgs e)
        {
            if (count > 0)
            {
                this.flpFood.Enabled = false;
                this.label2.Text = "Hóa Đơn";
                this.btnLapHoaDon.Text = "In Hóa Đơn Và Thanh Toán";

                this.flpCTHD.Controls.Add(lapHoaDon());

                this.btnLapHoaDon.Click -= LapHoaDon;
                this.btnLapHoaDon.Click += ThanhToan;
            }
        }

        private void ThanhToan(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công");
            string maHD ="HD" + ConnectFun.RunQuery("Select * From HoaDon_ThucAn").Rows.Count.ToString();
            DateTime now = DateTime.Now;
            string ngayMua = now.Year.ToString() + "/" + now.Month.ToString() + "/" + now.Day.ToString();
            string query = "Insert Into HoaDon_ThucAn Values('" + maHD + "','" + price.ToString() + "','" + ngayMua + "')";
            ConnectFun.RunQuery(query);
            this.btnLapHoaDon.Click -= ThanhToan;
            this.btnLapHoaDon.Click += LapHoaDon;
            KhoiTao();
        }

        private FlowLayoutPanel lapHoaDon()
        {
            FlowLayoutPanel pnHD = new FlowLayoutPanel();
            pnHD.BackColor = Color.White;
            pnHD.Location = new System.Drawing.Point(3, 3);
            pnHD.Name = "pnHoaDon";
            pnHD.Size = new System.Drawing.Size(440, 420);
            pnHD.TabIndex = 0;

            Label lbName = new Label();
            lbName.Text = "Tên sản phẩm";
            lbName.Size = new Size(150, 20);
            Label lbNumber = new Label();
            lbNumber.Text = "Số lượng";
            lbNumber.Size = new Size(150, 20);
            Label lbPrice = new Label();
            lbPrice.Text = "Giá";

            pnHD.Controls.Add(lbName);
            pnHD.Controls.Add(lbNumber);
            pnHD.Controls.Add(lbPrice);

            foreach (Panel item in flpCTHD.Controls)
            {
                Label foodName = item.Controls.Find("foodNameChosen", false).FirstOrDefault() as Label;
                TextBox foodNumber = item.Controls.Find("foodNumber", false).FirstOrDefault() as TextBox;
                Label foodPrice = item.Controls.Find("fPrice", false).FirstOrDefault() as Label;
                Label lbFoodName = new Label();
                lbFoodName.Text = foodName.Text;
                lbFoodName.Size = new Size(150, 20);

                Label lbFoodNumber = new Label();
                lbFoodNumber.Text = foodNumber.Text;
                lbFoodNumber.Size = new Size(150, 20);

                Label lbFoodPrice = new Label();
                lbFoodPrice.Text = string.Format("{0:#,##}", int.Parse(foodPrice.Text) * int.Parse(lbFoodNumber.Text)) + "đ";

                pnHD.Controls.Add(lbFoodName);
                pnHD.Controls.Add(lbFoodNumber);
                pnHD.Controls.Add(lbFoodPrice);
            }
            this.flpCTHD.Controls.Clear();
            return pnHD;
        }
    }
}
