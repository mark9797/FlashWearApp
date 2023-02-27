using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceApplication2
{
    public class TimeHandler
    {
        int s;
        int m;
        int h;
        Form1 f;
        public TimeHandler(Form1 f)
        {
            s = 0;
            m = 0;
            h = 0;
            this.f = f;
        }

        public void incSec()
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
            }
            string ss = (s < 10) ? "0" + Convert.ToString(s) : Convert.ToString(s);
            string ms = (m < 10) ? "0" + Convert.ToString(m) : Convert.ToString(m);
            string hs = (h < 10) ? "0" + Convert.ToString(h) : Convert.ToString(h);
            f.updateTime(ss,ms,hs);
        }

        
    }
}
