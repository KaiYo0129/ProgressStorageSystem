using BizDataLibrary;
using BizDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizDataTest001
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService service = new ProductService();
            List<Product> products = new List<Product>()
            {
                new Product() { PartNo = "A001", PartName = "小號一字起子" },
                new Product() { PartNo = "A002", PartName = "大號一字起子" },
                new Product() { PartNo = "B001", PartName = "小號十字起子" },
                new Product() { PartNo = "B002", PartName = "大號十字起子" },
            };

            /*foreach (var p in products)
            {
                service.Create(p);
            }
            Console.WriteLine("資料加入完成");*/

            var result = service.GetAll();
            Console.WriteLine("資料庫裡有的資料是....");
            foreach (var r in result) {
                Console.WriteLine($"料號{ r.PartNo}:品名{r.PartName}");
            }

            Console.WriteLine("=====================");

            var product = service.GetByPartNo("B001");
            Console.WriteLine($"取得品名為:{product.PartName}");

            Console.ReadLine();
        }
    }
}
