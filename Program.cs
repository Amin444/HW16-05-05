using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW16_03_05
{
 class Program
    {
        static void Main(string[] args)
        {
            List<shifts> mylist=new List<shifts>();
            while(true)
            {
                
                Task.Run(
                ()=>
                {
                    for (int i = 0; i < new Random().Next(100, 1000); i++)
                    {
                        mylist.Add(new shifts()
                        {
                            left=new Random().Next(100),
                            Top = new Random().Next(3,8)
                            
                        }
                        
                        );
                    }
                }
                ).Wait();


            }
         


        }
       
        
   }

     class shifts
     {
         public int left{get;set;}
         public int Top{get;set;} 
         public char[] simvol { get; set; }
     }
}
