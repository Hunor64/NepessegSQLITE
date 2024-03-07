using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepesseg
{
    internal class Orszag
    {
        string Ország, Terület, Főváros;
        int Népesség, FővárosNépessége;
        public Orszag(string sor)
        {

            List<string> felbontottSor = sor.Trim().Split(';').ToList();
            this.Ország = felbontottSor[0];
            this.Terület = felbontottSor[1];
            try
            {
                this.Népesség = int.Parse(felbontottSor[2]);
            }
            catch
            {
                int temp_elem = int.Parse(felbontottSor[2].Remove(felbontottSor[2].Length-1));
                this.Népesség = temp_elem*10000;
            }
            this.Főváros = felbontottSor[3];
            this.FővárosNépessége = int.Parse(felbontottSor[4]);

        }
    }
}
