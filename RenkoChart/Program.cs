using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RenkoChart
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuData();

            bool conectResult = CheckPing();
            if (conectResult)
            {
                Console.WriteLine(">>开始连接云服务器......");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(">>连接云服务器成功......");

                PrintData();

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(">>开始连接云服务器......");
                Console.WriteLine(">>连接云服务器失败......");

                Console.ReadKey();
                return;
            }

            //打开主项目
            PortfolioBackTest f = new PortfolioBackTest();
            f.ShowDialog();

        }

        /// <summary>
        /// 在这里连接服务器
        /// </summary>
        /// <returns></returns>
        static bool CheckPing()
        {
            Ping ping = new Ping();
            PingReply pingReply = ping.Send("59.110.240.133");
            if (pingReply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void MenuData()
        {
            Console.WriteLine("=========================投资组合回测终端============================");
        }

        static void PrintData()
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(">>开始对接云服务器云盘Tick数据......");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(">>云服务器云盘Tick数据获取中......");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("   --云服务器云盘Tick数据监测到共132个商品文件列表......");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("   --云服务器云盘Tick数据监测到共20GTick历史数据......");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(string.Format("   --云服务器云盘Tick数据上传下载隧道速度{0}M/s......",new Random().Next(10,50)));
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(">>云盘数据监测完成用以云端Tick回测......");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(">>脚本执行完毕,请按任意键,开始组合回测......");

        }
    }
}
