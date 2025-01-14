using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookking
{
    public class Dates
    {
        int dayOfMonth;
        private int month;

        public int DayOfMonth
        {
            get => dayOfMonth;
            set => dayOfMonth = value;
        }

        public int Month
        {
            get => month;
            set => month = value;
        }

        public Dates(int dayOfMonth = 0, int month = 0)
        {
            this.DayOfMonth = dayOfMonth;
            this.Month = month;
        }
    }
}
