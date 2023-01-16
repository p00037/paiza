//下記の問題をプログラミングしてみよう！
//0 または 1 の整数 A, B, C, D が与えられます。 以下の式を計算した結果を出力してください。


// See https://aka.ms/new-console-template for more information

string inputLine = Console.ReadLine() ?? "";
string[] inputs = inputLine.Split(" ");

bool A = (int.Parse(inputs[0]) == 1);
bool B = (int.Parse(inputs[1]) == 1);
bool C = (int.Parse(inputs[2]) == 1);
bool D = (int.Parse(inputs[3]) == 1);

if ((((A! && B!) || C!)!) ^ D)
{
    Console.WriteLine("1");
}

Console.WriteLine("0");