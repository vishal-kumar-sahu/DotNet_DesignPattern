namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FinalBillAmount finalBillAmount;

            Console.WriteLine("Card type available are : ");
            Console.WriteLine("Membership Card - Enter 1");
            Console.WriteLine("Employee Card - Enter 2");
            Console.WriteLine("No Card - Enter 3");

            Console.WriteLine("Enter the card type : ");
            int cardType = Convert.ToInt32(Console.ReadLine());

            switch(cardType)
            {
                case 1:
                    finalBillAmount = new FinalBillAmount(new LowDiscount());
                    break;

                case 2:
                    finalBillAmount = new FinalBillAmount(new HighDiscount());
                    break;

                default:
                    finalBillAmount = new FinalBillAmount(new NoDiscount());
                    break;
            }

            Console.WriteLine("Enter the Billed Amount : ");
            double billedAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();    

            Console.Write("Amount to be paid after discount i.e final billed amount : ");
            Console.WriteLine(finalBillAmount.GetFinalBillAmount(billedAmount));
            Console.WriteLine();
        }
    }
}
