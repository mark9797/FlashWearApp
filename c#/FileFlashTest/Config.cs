using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFlashTest
{
    public static class Config
    {
        private static int filecount;

        public static int Filecount
        {
            get { return filecount; }
            set { filecount = value; }
        }
    }
}
