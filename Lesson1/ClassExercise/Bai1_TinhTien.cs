using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Ex1_CalculateTotalAmount
    {
        public static double CalculateTotalAmount(double unitPrice, int quantity)
        {
            double totalPrice = unitPrice * quantity;
            if(totalPrice > 100)
            {
                double discount = totalPrice * 0.03;
                totalPrice -= discount;
            }
            return totalPrice;
        }
    }
}
