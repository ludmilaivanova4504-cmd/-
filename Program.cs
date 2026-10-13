using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сукеник
{
    class Computer
    {
        public int InventoryNumber;
        public double CpuFrequency;
        public int HardDiskSize;

        public void Show()
        {
            Console.WriteLine("=== Данные о компьютере ===");
            Console.WriteLine($"Инвентарный номер : {InventoryNumber}");
            Console.WriteLine($"Частота процессора: {CpuFrequency} ГГц");
            Console.WriteLine($"Объём жёсткого диска: {HardDiskSize} ГБ");
        }

        public double MemoryCost(double pricePerGB)
        {
            return HardDiskSize * pricePerGB;
        }
    }

    class Program
    {
        static void Main()
        {
            Computer comp = new Computer();
            comp.InventoryNumber = 123345;
            comp.CpuFrequency = 1.5;
            comp.HardDiskSize = 400;

            comp.Show();

            double pricePerGB = 100.0;
            double totalCost = comp.MemoryCost(pricePerGB);
            Console.WriteLine($"\nСтоимость внешней памяти ({comp.HardDiskSize} ГБ × {pricePerGB} руб.) = {totalCost} руб.");

            Console.ReadKey();
        }
    }
}
