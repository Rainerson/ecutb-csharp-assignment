﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Project.Services
{
    internal class FileService
    {
        public void SaveToFile(string filePath, string content)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(content);
        }
        public string ReadFile(string filePath)
        {
            try
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
            catch
            {
                return null!;
            }
        }

    }
}
