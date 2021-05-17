using System;

namespace Home_work_class2._2
{
    class Account
    {
        private decimal summ;
        private Guid accountNum;
        private DateTime data;
       

        public decimal Summ
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
        public Account(decimal summ, Guid accountNum, DateTime data)
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
            
            Console.WriteLine($"Дата открытия:{data.ToString("D")}.");
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
        public IndividualAccount(string accountType, decimal summ, Guid accountNum, DateTime data) : base(summ, accountNum, data)
        {
            AccountType = accountType;
        }
        public decimal PercentPlusInd(DateTime data, decimal summ)
        {
            int years = DateTime.Now.Year - data.Year;
            for (int i = 0; i < years; i++)
            {
                summ += summ * 0.10M;
            }
            Console.WriteLine($"За {years} год/года/лет, ваш баланс стал {summ} АЗН.");
            return summ;
        }
        public decimal Cash(decimal summ)
        {
            decimal cash = 0;
            bool temp = false;
            while (temp==false)
            {
                Console.WriteLine("Укажите сумму, которую хотите обналичить:");
                cash = Convert.ToInt32(Console.ReadLine());
                if (cash>summ)
                {
                    Console.WriteLine($"В балансе не достаточно средств. Ваш баланс {summ} АЗН.");
                }
                else
                {
                    summ -= cash;
                    temp = true;
                }
            }
            Console.WriteLine($"Вы сняли {cash} АЗН, ostalos {summ} АЗН.");
            return summ;
        }
        
    }
    class MMC : Account
    {
        public MMC(decimal summ, Guid accountNum, DateTime data) : base(summ, accountNum, data)
        {

        }
        public decimal PercentPlusMmc(DateTime data, decimal summ)
        {
            int years = DateTime.Now.Year - data.Year;
            for (int i = 0; i < years; i++)
            {
                summ += summ * 0.11M;
            }
            Console.WriteLine($"За {years} год/года/лет, ваш баланс стал {summ} АЗН.");
            return summ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2020, 10, 10);
            decimal sum = 1000;
            IndividualAccount individual = new IndividualAccount("Физический счет",sum, Guid.NewGuid(), data);
            individual.GetDisplaySumm();
            individual.GetDispleyData();
            sum = individual.PercentPlusInd(data, sum);
            sum = individual.Cash(sum);
            DateTime dataTwo= new DateTime(2015, 11, 12); 
            decimal sumTwo = 5000;
            MMC company = new MMC(sumTwo, Guid.NewGuid(), dataTwo);
            sumTwo = company.PercentPlusMmc(dataTwo,sumTwo);



            Console.ReadKey();

        }
    }
}
