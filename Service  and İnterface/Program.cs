using Service__and_İnterface;
using Service__and_İnterface.Service;
using Service__and_İnterface.Service.İnterface;





//Calculator proqrami duzeltmek ( ancaq toplama, vurma, bolme, cixma emelleri olacaq).
//Service folderi olacaq. Qeyd : Calculation classi, ICalculation interface,
//Calculate methodunuz olacaq. Bunlardan istifade edib projecti yazin.
#region task1




//ICalculation calculation = new Calculation();
//calculation.Calculate();
//Ccalculate();

//static void Ccalculate()
//{


//    Console.WriteLine("add first number");
//number1: string number1 = (Console.ReadLine());

//    int checkednum1;
//    bool IsParseNum1 = int.TryParse(number1, out checkednum1);


//    if (!IsParseNum1)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("please add correct format number 1");
//        Console.ResetColor();
//        goto number1;
//    }


//    Console.WriteLine("add operation :");
//    string operation = (Console.ReadLine());



//    Console.WriteLine("add second number 2");


//number2: string number2 = (Console.ReadLine());

//    int checkednum2;
//    bool IsParseNum2 = int.TryParse(number2, out checkednum2);


//    if (!IsParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("please add correct format number 2");
//        Console.ResetColor();
//        goto number2;
//    }

//    if (checkednum2 == 0 && operation == "/")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("please dont add 0");
//        Console.ResetColor();
//        goto number2;
//    }

//    var result = Service__and_İnterface.Service.Calculation.calculate(checkednum1, checkednum2, operation);

//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(result);
//    Console.ResetColor();
//}

#endregion



//Login mentiqini service ve interface ile yazmaq. (IAccountService, AccountService isdifade etmekle).
#region task2


IAccountService accountService = new AccountService();
accountService.Account("cavid123", "Cavid1993");
#endregion







// Dersde yazdiqlarimizi praktika edin.
#region task3


//Animal animal = new Animal();
//animal.Sound();


//Bird bird = new Bird();

//bird.Sound();
//bird.Eating();

//Shark shark = new Shark();
//shark.Sound();
////shark.Eating();

//Car car = new Car();
//car.Test();

//GetNums(1, 2, 3, 4, 5, 6, 7);
//static void GetNums( int num2,int num3,params int[] arr)
//{
//	foreach (var item in arr)
//	{
//		Console.WriteLine(item);
//	}
//}


//String str = new String("salam");


//string str = "salam";
//Console.WriteLine(str);

#endregion