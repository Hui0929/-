using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ojMovie.lei
{
    /// <summary>
    /// 售票系统电影票的基类 可以实例化普通票
    /// </summary>
    [Serializable]
    public class Ticket
    {
        public Ticket() { }
        public Ticket(ScheduleItem scheduleItem, Seat seat)
        {
            this.ScheduleItem = scheduleItem;
            this.Seat = seat;
        }

        /// <summary>
        /// 座位对象
        /// </summary>
        private Seat seat;
        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        /// <summary>
        /// 票价
        /// </summary>
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// 所属的放映场次
        /// </summary>
        private ScheduleItem scheduleItem;
        public ScheduleItem ScheduleItem
        {
            get { return scheduleItem; }
            set { scheduleItem = value; }
        }

        /// <summary>
        /// 计算票价的方法
        /// 可重写
        /// </summary>
        public virtual void CalcPrice()
        {
            this.Price = this.ScheduleItem.Movie.Price;
        }

        /// <summary>
        /// 打印票实现
        /// </summary>
        public virtual void Print()
        {
            string info = string.Format("************************************************\n\t瓯江影视文化（普通票）\n------------------------------------------------\n" +
            "电影名：\t{0}\n时间：\t{1}\n座位号：\t{2}\n价格：\t{3}\n************************************************",
           this.ScheduleItem.Movie.MovieName, this.ScheduleItem.Time, this.Seat.SeatNum, this.Price);
            MessageBox.Show(info);
            string fileName = this.ScheduleItem.Time.Replace(":", "-") + " " + this.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("***************************");
            sw.WriteLine("        瓯江影视文化");
            sw.WriteLine("---------------------------");
            sw.WriteLine(" 电影名：\t{0}", this.ScheduleItem.Movie.MovieName);
            sw.WriteLine(" 时间：  \t{0}", this.ScheduleItem.Time);
            sw.WriteLine(" 座位号：\t{0}", this.Seat.SeatNum);
            sw.WriteLine(" 价格：  \t{0}", this.Price.ToString());
            sw.WriteLine("***************************");
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 显示售出票信息
        /// </summary>
        public virtual void Show()
        {
            MessageBox.Show("已售出");
        }


    }
}
