namespace PixelBot_V1_Self
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program tạm thời đóng vai test harness để gọi Chat và kiểm tra kết quả.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*Chat chat = new Chat();
            string ketqua = chat.XuLy("chào nha");
            Console.WriteLine(ketqua);*/

            MayTinh maytinh = new MayTinh();
            int ketqua = maytinh.NhanYeuCau("25-7");
            Console.WriteLine(ketqua);
        }
    }
}
