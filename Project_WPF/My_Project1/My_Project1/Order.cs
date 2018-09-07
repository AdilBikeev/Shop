using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project1
{
    public class Order
    {
        private string name_subject;//тематика заказа
        private string name_order;//название заказа
        private int price;//стоимость
        private string run_time;//время выполнения
        private string perfomer;//исполнитель
        private string comment;//комментарий заказчика
        private int progress_order;//прогрессс заказа

        public string NAME_SUBJECT
        {
            get { return name_subject; }
        }

        public string NAME_ORDER
        {
            get { return name_order; }
        }

        public int PRICE
        {
            get { return price; }
        }

        public string RUN_TIME
        {
            get { return run_time; }
        }

        public string COMMENT
        {
            get { return comment; }
        }

        public string PERFOMER
        {
            get { return perfomer; }
        }

        public int PROGRESS_ORDER
        {
            get { return progress_order; }
        }

        public Order(string name_subject, string name_order, int price, string run_time)//конструктор для заказчиков
        {
            this.name_subject = name_subject;
            this.name_order = name_order;
            this.price = price;
            this.run_time = run_time;
        }

        public Order(string name_subject, string name_order, int price, string run_time, string perfomer, string comment, int? progress_order)//конструктор для персонала
        {
            this.name_subject = name_subject;
            this.name_order = name_order;
            this.price = price;
            this.run_time = run_time;
            this.perfomer = perfomer;
            this.comment = comment;
            this.progress_order = progress_order!=null? (int)progress_order:0;
        }

        public Order()
        {

        }
    }
}
