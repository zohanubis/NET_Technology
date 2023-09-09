using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExercise
{
    public class KTAmDuong
    {
        public static string KiemTraAmDuong(int number)
        {
            return (number > 0) ? "positive" : (number < 0) ? "negative" : "neither positive nor negative ";    
        }
    }
}
