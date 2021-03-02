using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameters
{
    class Program
    {
        public static void GetCohortDetails(string CName,int GCount,string mode,string track,string Curr_Module) 
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}",CName,GCount,mode,track,Curr_Module);
        }
        static void Main(string[] args)
        {
            GetCohortDetails("ADM",21,"PARC",".NET","Stage 3");
            GetCohortDetails(mode:"OBL",track:"JAVA",CName:"ADM",GCount:21,Curr_Module:"Stage 3");
            Console.ReadLine();
        }
    }
}
