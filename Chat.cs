using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelBot_V1_Self
{
    internal class Chat
    {

        //nhận và xử lý yêu cầu của user
       public string XuLy(string yeuCau)
        {
            return GioiThieu();
        }


        private string GioiThieu()
        {
            return "Mình là PixelBot V1_Self, được tạo ra bởi Cún Pixel và viết bằng ngôn ngữ C#";
        }

    }
}
