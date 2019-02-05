using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ComputerShop
{
    public void ConstructComputer(ComputerBuilder computerBuilder)
    {
        computerBuilder.BuildMotherboard();
        computerBuilder.BuildProcessor();
        computerBuilder.BuildHardDisk();
        computerBuilder.BuildScreen();
    }
}

public class Computer
{
    private ComputerTyp _computerTyp;

    public string MotherBoard { get; set; }
    public string HardDisk { get; set; }
    public string Screen { get; set; }
    public string Processor { get; set; }


    public Computer(ComputerTyp computerTyp)
    {
        _computerTyp = computerTyp;
    }

    public void DisplayConfiguration()
    {
        string message;
        message = string.Format("Computer: {0}", _computerTyp);
        Console.WriteLine(message);
        message = string.Format("Motherboard: {0}", MotherBoard);
        Console.WriteLine(message);
        message = string.Format("Screen: {0}", Screen);
        Console.WriteLine(message);
        message = string.Format("HardDisk: {0}", HardDisk);
        Console.WriteLine(message);
    }
}

public enum ComputerTyp
{
    Apple,
    Desktop,
    Laptop
}


public abstract class ComputerBuilder
{
    public Computer Computer { get; set; }
    public abstract void BuildMotherboard();
    public abstract void BuildProcessor();
    public abstract void BuildHardDisk();
    public abstract void BuildScreen();
}

public class DesktopBuilder : ComputerBuilder
{
    public DesktopBuilder()
    {
        Computer = new Computer(ComputerTyp.Desktop);
    }

    public override void BuildHardDisk()
    {
        Computer.HardDisk = "2TB";
    }

    public override void BuildScreen()
    {
        Computer.Screen = "21 inch (1980 x 1200)";
    }

    public override void BuildProcessor()
    {
        Computer.Processor = "ProcessorDesktop";
    }

    public override void BuildMotherboard()
    {
        Computer.MotherBoard = "MotherboardDesktop";
    }
}


public class LaptopBuilder : ComputerBuilder
{
    public LaptopBuilder()
    {
        Computer = new Computer(ComputerTyp.Laptop);
    }

    public override void BuildHardDisk()
    {
        Computer.HardDisk = "2TB Laptop";
    }

    public override void BuildScreen()
    {
        Computer.Screen = "21 inch (1980 x 1200) Laptop";
    }

    public override void BuildProcessor()
    {
        Computer.Processor = "ProcessorLaptop";
    }

    public override void BuildMotherboard()
    {
        Computer.MotherBoard = "MotherboardLaptop";
    }

}


public class AppleBuilder : ComputerBuilder
{
    public AppleBuilder()
    {
        Computer = new Computer(ComputerTyp.Apple);
    }

    public override void BuildHardDisk()
    {
        Computer.HardDisk = "2TB Apple";
    }

    public override void BuildScreen()
    {
        Computer.Screen = "21 inch (1980 x 1200) Apple";
    }

    public override void BuildProcessor()
    {
        Computer.Processor = "ProcessorApple";
    }

    public override void BuildMotherboard()
    {
        Computer.MotherBoard = "MotherboardApple";
    }

}

/* ############################################# */


public class Program
{
    static void Main(string[] args)
    {




        Console.WriteLine("------------");

        AppleBuilder computerBuilder = new AppleBuilder();
        ComputerShop computerShop = new ComputerShop ();
        computerShop.ConstructComputer(computerBuilder);
        computerBuilder.Computer.DisplayConfiguration();

        Console.WriteLine("------------");

        LaptopBuilder laptopBuilder = new LaptopBuilder();
        ComputerShop laptopShop = new ComputerShop();
        laptopShop.ConstructComputer(laptopBuilder);
        laptopBuilder.Computer.DisplayConfiguration();

        Console.WriteLine("------------");

        DesktopBuilder desktopBuilder = new DesktopBuilder();
        ComputerShop desktopShop = new ComputerShop();
        desktopShop.ConstructComputer(desktopBuilder);
        desktopBuilder.Computer.DisplayConfiguration();
        Console.ReadLine();

    }
}