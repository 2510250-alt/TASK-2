
namespace TASK_2
{
    class StudentDiscount : Discount
    {
        public override double CalculateDiscount(double price)
        {
            return price * 0.10;
        }
    }
}
