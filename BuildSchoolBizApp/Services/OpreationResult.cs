﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchoolBizApp.Services
{
    public class OperationResult
    {
        public bool IsSuccessful { get; set; }
        public Exception exception { get; set; }
    }

    public static class OperationResultHelper
    {
        public static string WriteLog(this OperationResult value)
        {
            if (value.exception != null)
            {
                string path = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                path = path + ".txt";
                File.WriteAllText(path, value.exception.ToString());
                return path;
            }
            else
            {
                return "No Save File";
            }
        }
    }
}
