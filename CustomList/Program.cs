using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(12);
            customList.Add(13);
            customList.Add(14);
            customList.Add(15);
            customList.Remove(13); 
         

            
        }
    }
}
