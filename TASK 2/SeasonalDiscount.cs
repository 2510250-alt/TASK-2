
namespace TASK_2
{
    class SeasonalDiscount : Discount
    {
        public override double CalculateDiscount(double price)
        {
            return price * 0.20;
        }
    }
}
