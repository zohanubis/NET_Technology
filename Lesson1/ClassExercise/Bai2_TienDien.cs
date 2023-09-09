using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Ex2_ElectricityBill
    {
        //Cách 1
        public static double CalculateElectricityBill1(int electricityUsage)
        {
            double totalBill = 0;

            if (electricityUsage <= 100)
            {
                totalBill = electricityUsage * 5;
            }
            else if (electricityUsage <= 150)
            {
                totalBill = 100 * 5 + (electricityUsage - 100) * 7;
            }
            else if (electricityUsage <= 200)
            {
                totalBill = 100 * 5 + 50 * 7 + (electricityUsage - 150) * 105;
            }
            else if (electricityUsage <= 300)
            {
                totalBill = 100 * 5 + 50 * 7 + 50 * 105 + (electricityUsage - 200) * 155;
            }
            else
            {
                totalBill = 100 * 5 + 50 * 7 + 50 * 105 + 100 * 155 + (electricityUsage - 300) * 205;
            }

            return totalBill;
        }
        // Cách 2
        public static double CalculateElectricityBill(int electricityUsage)
        {
            double totalBill = 0;

            // Định nghĩa các ngưỡng và giá tương ứng
            int[] usageThresholds = { 100, 150, 200, 300 };
            double[] usagePrices = { 5, 7, 10.5, 15.5, 20.5 };

            int prevThreshold = 0;

            for (int i = 0; i < usageThresholds.Length; i++)
            {
                if (electricityUsage > usageThresholds[i])
                {
                    totalBill += (usageThresholds[i] - prevThreshold) * usagePrices[i];
                    prevThreshold = usageThresholds[i];
                }
                else
                {
                    totalBill += (electricityUsage - prevThreshold) * usagePrices[i];
                    break;
                }
            }

            return totalBill;
        }
    }
}
