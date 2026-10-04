using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelBot_V1_Self
{
    internal class MayTinh
    {
        public int NhanYeuCau(string bieuThuc) //bieuThuc là parameter, không được quên công dụng của nó
        {
            string s = bieuThuc;

            int operatorIndex = -1;

            for(int i = 0; i < bieuThuc.Length; i++ )
            {
                if (bieuThuc[i] == '+' || 
                    bieuThuc[i]== '-'  || 
                    bieuThuc[i] == '*' ||
                    bieuThuc[i] == '/')  //bieuThuc[i] = "lấy ký tự ở vị trí i trong chuỗi bieuThuc
                {
                    operatorIndex = i; //operatorIndex = vị trí vừa tìm được
                    break;
                }    
            }    


            string a = s.Substring(0, 3);
            int A = int.Parse(a);

            string b = s.Substring(4); //C# sẽ tự hiểu là lấy từ index 4 đến hết chuỗi
            int B = int.Parse(b);

            string c = s.Substring(3, 1);

            int Result = 0;
            switch (c)
            {
                case "+":
                    Result = A+B;
                    break;
            }

            return Result;
        }
    }
}
