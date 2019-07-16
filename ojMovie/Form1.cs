using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ojMovie.lei;

namespace ojMovie
{
    public partial class Form1 : Form
    {
        Cinema cinema;
        
        Dictionary<string, Label> labels = new Dictionary<string, Label>();
        int ticket = 0;
        string key = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblActor.Text = "";
            this.lblDirector.Text = "";
            this.lblMovieName.Text = "";
            this.lblPrice.Text = "";
            this.lblTime.Text = "";
            this.lblType.Text = "";
            this.lblCalcPrice.Text = "";
            this.txtCustomer.Enabled = false;
            this.cmbDisCount.Enabled = false;
            this.rdoNormal.Checked = true;

            cinema = new Cinema();
            //初始化放映厅座位
            InitSeats(7, 5, tpCinema);


            cinema.Load();

        }
        private void InitSeats(int seatRow, int seatLine, TabPage tb)
        {
            Label label;
            Seat seat;
            

            for (int j = 0; j < seatLine ; j++)
            {
                if (j == seatLine - 1)
                {
                    for (int i = 0; i < seatRow-2; i++)
                    {
                        label = new Label();
                        //设置背景颜色
                        label.BackColor = Color.Yellow;
                        //设置字体
                        label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        //设置尺寸
                        label.AutoSize = false;
                        label.Size = new System.Drawing.Size(80, 25);
                        //设置座位号
                        label.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        //设置位置
                        label.Location = new Point(70 + (i * 120), 60 + (j * 60));
                        //所有的标签都绑定到同一事件
                        label.Click += new System.EventHandler(lblSeat_Click);
                        tb.Controls.Add(label);
                        labels.Add(label.Text, label);
                        //实例化一个座位
                        seat = new Seat((j + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);
                        //保存的座位集合
                        cinema.Seats.Add(seat.SeatNum, seat);
                    }
                }
                else
                {

                    for (int i = 0; i < seatRow; i++)
                    {
                        label = new Label();
                        //设置背景颜色
                        label.BackColor = Color.Yellow;
                        //设置字体
                        label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        //设置尺寸
                        label.AutoSize = false;
                        label.Size = new System.Drawing.Size(50, 25);
                        //设置座位号
                        label.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        //设置位置
                        label.Location = new Point(60 + (i * 90), 60 + (j * 60));
                        //所有的标签都绑定到同一事件
                        label.Click += new System.EventHandler(lblSeat_Click);
                        tb.Controls.Add(label);
                        labels.Add(label.Text, label);
                        //实例化一个座位
                        seat = new Seat((j + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);
                        //保存的座位集合
                        cinema.Seats.Add(seat.SeatNum, seat);
                    }
                }

            }


              /*  for (int i = 0; i < seatRow; i++)
            {
                for (int j=0; j < seatLine-1; j++)
                {
                    if (j ==(seatLine-1))
                    {
                       
                        label = new Label();
                        //设置背景颜色
                        label.BackColor = Color.Yellow;
                        //设置字体
                        label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        //设置尺寸
                        label.AutoSize = false;
                        label.Size = new System.Drawing.Size(80, 25);
                        //设置座位号
                        label.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        //设置位置
                        label.Location = new Point(60 + (i * 90), 60 + (j * 60));
                        //所有的标签都绑定到同一事件
                        label.Click += new System.EventHandler(lblSeat_Click);
                        tb.Controls.Add(label);
                        labels.Add(label.Text, label);
                        //实例化一个座位
                        seat = new Seat((j + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);
                        //保存的座位集合
                        cinema.Seats.Add(seat.SeatNum, seat);
                       
                    } 
                   // else
                    {
                        label = new Label();
                        //设置背景颜色
                        label.BackColor = Color.Yellow;
                        //设置字体
                        label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        //设置尺寸
                        label.AutoSize = false;
                        label.Size = new System.Drawing.Size(50, 25);
                        //设置座位号
                        label.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        //设置位置
                        label.Location = new Point(60 + (i * 90), 60 + (j * 60));
                        //所有的标签都绑定到同一事件
                        label.Click += new System.EventHandler(lblSeat_Click);
                        tb.Controls.Add(label);
                        labels.Add(label.Text, label);
                        //实例化一个座位
                        seat = new Seat((j + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);
                        //保存的座位集合
                        cinema.Seats.Add(seat.SeatNum, seat);
                    }
                }
            }*/
          
        }
        private void lblSeat_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(this.lblMovieName.Text))
            {
                MessageBox.Show("您还没选择电影!", "提示");
                return;
            }
            ticket++;
            try
            {
                string seatNum = ((Label)sender).Text.ToString();
                string customerName = this.txtCustomer.Text.ToString();
                int discount = 0;
                string type = "";
                if (this.rdoStudent.Checked)
                {
                    type = "student";
                    if (this.cmbDisCount.Text == null)
                    {
                        MessageBox.Show("请输入折扣数!", "提示");
                        return;
                    }
                    else
                    {
                        discount = int.Parse(this.cmbDisCount.Text);
                    }
                }
                else if (this.rdoFree.Checked)
                {
                    if (String.IsNullOrEmpty(this.txtCustomer.Text))
                    {
                        MessageBox.Show("请输入赠票者姓名!", "提示");
                        return;
                    }
                    else
                    {
                        type = "free";
                    }
                }


                //调用工具类创建票
                Ticket newTicket = TicketUtil.CreateTicket(cinema.Schedule.Items[key], cinema.Seats[seatNum],
                    discount, customerName, type);
                if (cinema.Seats[seatNum].Color == Color.Yellow)
                {
                    string a = seatNum;
                    a = a.Replace("-", "");
                    char[] b = a.ToCharArray();
                    string number = b[0].ToString();
                    if (number == "5")
                    {
                        DialogResult result;
                        result = MessageBox.Show("是否购买情侣座?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {

                            cinema.Seats[seatNum].Color = Color.Red;
                            UpdateSeat();
                            newTicket.CalcPrice();
                            cinema.SoldTickets.Add(newTicket);
                            lblCalcPrice.Text = newTicket.Price.ToString();
                            newTicket.Print();


                        }
                        else if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    //打印
                    else
                    {
                        DialogResult result;
                        result = MessageBox.Show("是否购买?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {

                            cinema.Seats[seatNum].Color = Color.Red;
                            UpdateSeat();
                            newTicket.CalcPrice();
                            cinema.SoldTickets.Add(newTicket);
                            lblCalcPrice.Text = newTicket.Price.ToString() ;
                            newTicket.Print();


                        }
                        else if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    //显示当前售出票的信息
                    foreach (Ticket ticket0 in cinema.SoldTickets)
                    {
                        //判断是否为同场次、同电影、同座位号
                        if (ticket0.Seat.SeatNum == seatNum && ticket0.ScheduleItem.Time == tvMovies.SelectedNode.Text && ticket0.ScheduleItem.Movie.MovieName == tvMovies.SelectedNode.Parent.Text)
                        {
                            ticket0.Show();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void UpdateSeat()
        {
            foreach (string key in cinema.Seats.Keys)
            {
                labels[key].BackColor = cinema.Seats[key].Color;
            }
        }

        private void tsmiNew_Click_1(object sender, EventArgs e)
        {
            cinema.Schedule.LoadItems();
            cinema.SoldTickets.Clear();
            InitTreeView();
        }
        private void InitTreeView()
        {
            tvMovies.BeginUpdate();
            tvMovies.Nodes.Clear();

            string movieName = null;
            TreeNode movieNode = null;
            foreach (ScheduleItem item in cinema.Schedule.Items.Values)
            {
                if (movieName != item.Movie.MovieName)
                {
                    movieNode = new TreeNode(item.Movie.MovieName);
                    tvMovies.Nodes.Add(movieNode);
                }
                TreeNode timeNode = new TreeNode(item.Time);
                movieNode.Nodes.Add(timeNode);
                movieName = item.Movie.MovieName;

            }
            tvMovies.EndUpdate();
        }

        private void tpCinema_Click(object sender, EventArgs e)
        {

        }

        private void tvMovies_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = tvMovies.SelectedNode;
            if (node == null) return;
            if (node.Level != 1) return;
            key = node.Text;
            //将详细信息显示
            this.lblMovieName.Text = cinema.Schedule.Items[key].Movie.MovieName;
            this.lblDirector.Text = cinema.Schedule.Items[key].Movie.Director;
            this.lblActor.Text = cinema.Schedule.Items[key].Movie.Actor;
            this.lblPrice.Text = cinema.Schedule.Items[key].Movie.Price.ToString();
            this.lblTime.Text = cinema.Schedule.Items[key].Time;
            this.lblType.Text = cinema.Schedule.Items[key].Movie.MovieType.ToString();
            this.picMovie.Image = Image.FromFile(cinema.Schedule.Items[key].Movie.Poster);
            this.lblCalcPrice.Text = "";

            //清空座位
            ClearSeat();
            //遍历该场电影的座位销售情况
            foreach (Ticket ticket in cinema.SoldTickets)
            {
                foreach (Seat seat in cinema.Seats.Values)
                {
                    if ((ticket.ScheduleItem.Time == key)
                        && (ticket.Seat.SeatNum == seat.SeatNum))
                    {
                        seat.Color = Color.Red;
                        cinema.Load();
                    }
                }
            }
            UpdateSeat();
        }
     

        private void ClearSeat()
        {
            foreach (Seat seat in cinema.Seats.Values)
            {
                seat.Color = Color.Yellow;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult close;
            close = MessageBox.Show("是否保存当前销售状态?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (close == DialogResult.Yes)
            {
                //退出时保存Cinema对象
                cinema.Save();
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            cinema.Save();
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            cinema.Save();
            this.Dispose();
        }
       

        private void cmbDisCount_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //根据当前选中的电影，设置“优惠价”
            if (this.lblPrice.Text != "")
            {
                int price = int.Parse(this.lblPrice.Text);
                int discount = int.Parse(this.cmbDisCount.Text);
                this.lblCalcPrice.Text = (price * discount / 10).ToString();
            }
        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Text = "";
            this.cmbDisCount.Enabled = true;
            this.cmbDisCount.Text = "7";
            //根据当前选中的电影，设置“优惠价”
            if (this.lblPrice.Text != "")
            {
                int price = int.Parse(this.lblPrice.Text);
                int discount = int.Parse(this.cmbDisCount.Text);
                this.lblCalcPrice.Text = (price * discount / 10).ToString();
            }
        }

        private void rdoFree_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCustomer.Enabled = true;
            this.cmbDisCount.Enabled = false;
            this.cmbDisCount.Text = "";
            //设置“优惠价”
            this.lblCalcPrice.Text = "0";
        }

        private void rdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbDisCount.Enabled = false;
            this.txtCustomer.Text = "";
            this.txtCustomer.Enabled = false;
            this.cmbDisCount.Text = "";
            this.lblCalcPrice.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}