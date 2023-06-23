using H_M_22;

var uzcard = new UzCard("1234 1234 1234 1234","Abdulla Zoirov",1000000);
var humo = new Humo("3421 1423 1342 1332","Xojiakbar Pulatov",70000);

uzcard.Add(5000);
Console.WriteLine(uzcard.Money);

uzcard.AddWithBonus(10000);
Console.WriteLine(uzcard.Money);

uzcard.Pay(505000);
Console.WriteLine(uzcard.Money);



Console.WriteLine(humo.PayWireless(50001));
Console.WriteLine(humo.Money);


humo.Pay(505000);
Console.WriteLine(humo.Money);
