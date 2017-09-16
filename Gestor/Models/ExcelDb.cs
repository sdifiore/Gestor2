using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;

namespace Gestor.Models
{
    public class ExcelDb
    {
        public void Estrutura()
        {
            var worksheets = new Stack<int>();
            worksheets.Push(2);

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook workbook = xlApp.Workbooks.Open(Files.CustoEstrutura);

            for (int i = 0; i < worksheets.Depth(); i++)
            {
                Excel._Worksheet worksheet = workbook.Sheets[i];
            }
        }
    }
}

// to be continued if needed