using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpu_scheduling_calculator
{
    public class Calc
    {
        bool loop = true;
        List<int> numbers = new List<int>();
        List<int> Bnumbers = new List<int>();
        // [p1,p2,p3,p4]  [5,4,3,2]
        public List<string> calc(List<int> PList , List<int> Blist)
        {
            loop = true;
            List<string> PNames = new List<string>();
            //      Arrival time      \\
            int p1 = PList[0];
            int p2 = PList[1];
            int p3 = PList[2];
            int p4 = PList[3];
            int p5 = PList[4];
            int p6 = PList[5];
            PList.Sort();

            //      Burst time      \\
            int B1 = Blist[0];
            int B2 = Blist[1];
            int B3 = Blist[2];
            int B4 = Blist[3];
            int B5 = Blist[4];
            int B6 = Blist[5];

            while (loop)
            {
                for (int n =0; n <=6 ; n++)
                {
                    if (PList[n] == p1)


                    {
                        PNames.Add("P1");
                        numbers.Add(p1);
                        Bnumbers.Add(B1);

                        //PList.RemoveAt(n);
                    }
                    if (PList[n] == p2)
                    {
                        PNames.Add("P2");
                        numbers.Add(p2);
                        Bnumbers.Add(B2);
                        //PList.RemoveAt(n);
                    }
                    if (PList[n] == p3)
                    {
                        PNames.Add("P3");
                        numbers.Add(p3);
                        Bnumbers.Add(B3);
                        //PList.RemoveAt(n);
                    }
                    if (PList[n] == p4)
                    {
                        PNames.Add("P4");
                        numbers.Add(p4);
                        Bnumbers.Add(B4);
                        //PList.RemoveAt(n);
                    }
                    if (PList[n] == p5)
                    {
                        PNames.Add("P5");
                        numbers.Add(p5);
                        Bnumbers.Add(B5);
                        //PList.RemoveAt(n);
                    }
                    if (PList[n] == p6)
                    {
                        PNames.Add("P6");
                        numbers.Add(p6);
                        Bnumbers.Add(B6);
                        //PList.RemoveAt(n);
                    }
                    if (PNames.Count == 6)
                    {
                       
                        loop = false;
                        break;
                    }

                }

            }
            return PNames;


        }
        List<int> Burst = new List<int>();
        public float Get_avg()
        {
            int first = numbers.AsQueryable().Min();
            Burst.Add(first);
            Burst.Add(Burst[0] + Bnumbers[0]);
            Burst.Add(Burst[1] + Bnumbers[1]);
            Burst.Add(Burst[2] + Bnumbers[2]);
            Burst.Add(Burst[3] + Bnumbers[3]);
            Burst.Add(Burst[4] + Bnumbers[4]);
            Burst.Add(Burst[5] + Bnumbers[5]);

            float avg = 0f;
            float res = 0f;
            for(int i = 0; i<=5; i++)
            {
                avg += Burst[i] - numbers[i];
            }
            res = avg / 6;
            return res;
        }
    }
}
