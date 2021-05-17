using System;

namespace Home_work_class2._2
{
    class Account
    {
        private int summ;
        private Guid accountNum;
        private DateTime data;
       

        public int Summ
        {
            get { return summ; }
            set { summ = value; }
        }
       

        public Guid AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public Account(int summ, Guid accountNum, DateTime data)
        {
            Summ = summ;
            AccountNum = accountNum;
            Data = data;
        }
        public void GetDisplaySumm()
        {
            Console.WriteLine($"В балансе {summ} АЗН.");
        }
        public void GetDispleyData()
        {
            
            Console.WriteLine($"Дата открытия:{"D: " + data.ToString("D")}.");
        }
    }
    class IndividualAccount : Account
    {
        private string accountType;

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public IndividualAccount(string accountType, int summ, Guid accountNum, DateTime data) : base(summ, accountNum, data)
        {
            AccountType = accountType;
        }

        public int Percent(int years, double sum)
        {
             
            if (years==0)
            {
                return 0;
            }
            else
            {
                
               return Percent(years--, sum * 0.08);
            }
        }
    }
/*    class MMC : Account
    {

    }*/
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2020, 10, 10);
            int sum = 1000;
            int years = DateTime.Now.Year - data.Year;
            Account newAccount = new Account(sum, Guid.NewGuid(),data);
            newAccount.GetDisplaySumm();
            newAccount.GetDispleyData();
        }
    }
}
