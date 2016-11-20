using System;

namespace FajnaApka
{
    class Program
    {
        static void Main(string[] args)
        {           
            var funcall1 = Function1("_w:bi", 2);
            var funcall2 = Function1("k=bgLYkHrb:CsCxv", 8);
            var funcall3 = Function1(".ePqpkSgcRK?", 8);
            var window1 = Function1("wKNIlMsHdx?t:YN9SSKORxiGnU:ReAsMEki", 4);
            Console.WriteLine(funcall1);
            Console.WriteLine(funcall2);
            Console.WriteLine(funcall3);
            Console.WriteLine(window1);
            Console.ReadKey();
        }

        private static string Function1(string input1, int startindex)
        {
            const string string2 = "=rZ3H5GKmB8pYN4UDebuhVcyISotf7dTnA9CXjF?xL1lkRMEs0vJi:_/Pzg2a6O.";
            string[] stringarray =
            {
                "5_maB9GZkVtn?zdOI4ENPlKpJ7:sxY/fFrA1USD0HcbTC3hovy=j6g2Xue.MiL8R",
                "6:7/sNBkyidH1?2VtlvY5n3hobOSR0rIe8FX9fpjZ_mxKPDL=cuEC.zUag4TJAGM",
                "/Nhk2JCZR=FE5ue3yYPIc8?4Uax:bgHtfApoOj_B0nlrT6GmXi1v7d9.DSLsVMKz",
                "mRTraSjiB7lgKAu5Pt:yk=UI0fb42Vz.vspGnFN/L18cHCEoJ63M9_XxYOZhed?D",
                "BTEuJc_4=RviNZX7bK9el5:U82xYj.SyPkzMGgOsd1nht6Ff0DorI3m?VAL/paCH",
                "40=BT2H7td_nb9hxVrYzGeIa3:lM?/kDX.gRNofjFKUm6suiAEPvLpy5J1cZC8OS"
            };
            var string1 = "";
            var int1 = 0;
            while (int1 < input1.Length)
            {
                var int3 = 0;
                var int4 = -1;
                while (int3 < string2.Length)
                {
                    if (string2[int3] == input1[int1])
                    {
                        int4 = int3;
                        break;
                    }
                    int3++;
                }
                if (int4 >= 0)
                {
                    var int5 = 0;
                    var int6 = -1;
                    while (stringarray[int1 % stringarray.Length].Length >int5)
                    {
                        if (stringarray[int1 % stringarray.Length][int5] == input1[int1])
                        {
                            int6 = int5;
                            break;
                        }
                        int5++;
                    }
                    string1 += string2[int6];
                }
                else
                {
                    string1 += input1[int1];
                }
                int1++;
            }
            return string1.Substring(startindex);
        }

    }
}
