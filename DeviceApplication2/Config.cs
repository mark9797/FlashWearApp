using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceApplication2
{
    public static class Config
    {
        public static readonly string[] headers = new string[9] { "ITERATIONS=", "MAJOR_ITERATIONS=", "FILE_SIZE=", "BLOCK_SIZE=", "FILE_FLUSH=", "REMOVE_FILE=", "TOTAL_DATA_AMOUNT=", "NUMBER_OF_THREADS=", "MAX_RUNNING_TIME=" };
        public static readonly int[] default_values = new int[9] { 100, 10, 1024, 1024, 0, 0, 0, 1, 0 };
        public static int[] current_values = default_values;
        private static string configFilePath = "Storage Card/Config.txt";

        /*
        private static int iterations = default_values[0];
        private static int major_iterations = default_values[1];
        private static int file_size = default_values[2]; //Bytes
        private static int block_size = default_values[3]; //Bytes
        private static int file_flush = default_values[4];
        private static int remove_file = default_values[5];
        private static int total_data_amount = default_values[6]; //Bytes, 0 equals none
        private static int number_of_threads = default_values[7];
        private static int max_running_time = default_values[8]; //Hours, 0 means none
        */

        public static string ConfigFilePath
        {
            get { return configFilePath; }
            set { configFilePath = value; }
        }

        public static int Iterations
        {
            get { return current_values[0]; }
            set { current_values[0] = value; }
        }
        public static int Major_iterations
        {
            get { return current_values[1]; }
            set { current_values[1] = value; }
        }

        public static int File_size
        {
            get { return current_values[2]; }
            set { current_values[2] = value; }
        }
        public static int Block_size
        {
            get { return current_values[3]; }
            set { current_values[3] = value; }
        }
        public static int File_flush
        {
            get { return current_values[4]; }
            set { current_values[4] = value; }
        }
        public static int Remove_file
        {
            get { return current_values[5]; }
            set { current_values[5] = value; }
        }
        public static int Total_data_amount
        {
            get { return current_values[6]; }
            set { current_values[6] = value; }
        }
        public static int Number_of_threads
        {
            get { return current_values[7]; }
            set { current_values[7] = value; }
        }
        public static int Max_running_time
        {
            get { return current_values[8]; }
            set { current_values[8] = value; }
        }
    }
}

/*
	options["ITERATIONS"] = 500;
	options["FILE_FLUSH"] = 1;
	options["FILE_DATA_APPEND"] = 1;
	options["CLOSE_FILE"] = 1;
	options["MAJOR_ITERATIONS"] = 2000;
	options["FILE_SIZE"] = 1024;
	options["BLOCK_SIZE"] = 1024;
	options["REMOVE_FILE"] = 1;
	options["CHANGE_FILE_NAME"] = 1;
	options["TOTAL_DATA_AMOUNT"] = 0;
	options["NUMBER_OF_THREADS"] = 1;
	options["MAX_RUNNING_TIME"] = 0; // Default, HOURS
	options["RUN_CONTINUOUSLY"] = 0;
*/