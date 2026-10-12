
namespace TASK_2
{
    class PremiumMemberDiscount : Discount
    {
        public override double CalculateDiscount(double price)
        {
            return (price * 0.15) + 100;
        }
    }
}
