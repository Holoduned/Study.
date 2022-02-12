﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Домашние__2_семестр._10._02
{
    class Programm
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string[] lines = FileManager.ReadFile(path);
            int[][] arrays = WorkWithArray.ArraysCreate(lines);

            WorkWithArray.ArrayPrint(WorkWithArray.DifferenceArray(arrays));
            WorkWithArray.ArrayPrint(WorkWithArray.ArrayMerge(arrays));
        }
    }
}
