using System; // 添加命名空间
// using YourNamespace; // 添加命名空间
/* 	
		数据类型分为【值类型】 跟 【引用类型】 
*/
// namespace System {
// 	public class Program {
// 		  static void Main(string[] args) {
// ...
// 		}
// 	}
// }

// 【值类型】 - 整数 ————————————————————————————————————————————————————————————————
// ⚡️有符号整数可以表示正数、负数和零，而无符号整数只能表示非负数和零
byte numG = 40; // 有符号的 8 位整数 
sbyte numH = 40; // 无符号的 8 位整数, 取值范围 -128 ~ 127

short numA = 40; // 有符号的 16 位整数, 取值范围 -32768 ~ 32767
ushort numD = 40; // 无符号的 16 位整数, 取值范围 0 ~ 65535

int numB = 40; // 有符号的 32 位整数 , 取值范围 -2147483648 ~ 2147483647	// 🌟 常用
uint numC = 40u; // 无符号的 32 位整数, 取值范围 0 ~ 4294967295

long numE = 40L; // 有符号的 64 位整数, 取值范围 -9223372036854775808 ~ 9223372036854775807 // 🌟 常用
ulong numF = 40UL; // 无符号的 64 位整数, 取值范围 0 ~ 18446744073709551615
Console.WriteLine("{0} {1} {2} {3} {4} {5}", numA, numB, numC, numD, numE, numF, numF);



// 【值类型】 - 浮点(带有小数点) ————————————————————————————————————————————————————————————————
float numI = 40.5f; // 【单精度, 需要加个 f 】浮点数, 占用 32 位空间, 4 个字节, 取值范围 -3.402823E+38 ~ 3.402823E+38
double numJ = 40.5; // 【双精度】浮点数, 占用 64 位空间, 8 个字节, 取值范围 -1.7976931348623157E+308 ~ 1.7976931348623157E+308
Console.WriteLine("{0} {1}", numI, numJ);



// 【字符类型】 ————————————————————————————————————————————————————————————————
char numK = 'A'; // 表示一个 16 位的 Unicode 字符, 单引号
string str = "Hello"; // 表示一个字符串, 双引号 【🌟 字符串是一个比较特殊的引用类型】
Console.WriteLine("{0} {1}", numK, str);



// 【布尔类型】 ————————————————————————————————————————————————————————————————
bool result = true;
bool result2 = false;
Console.WriteLine("{0} {1}", result, result2);



// 【结构体类型 - 🌟值类型】 ————————————————————————————————————————————————————————————————
// 结构体 Struct 是一种【值类型】, 类 Class 是一种【引用类型】
Person Designer = new Person(); //【🔥要放到 struct 的声明之前🔥】实例化一个结构体
Designer.Name = "Jimmy";
Designer.Age = "18";
Console.WriteLine(Designer.Name);


public struct Person {  // 结构体
	public string Name;
	public string Age;
}



// 【枚举类型】 ————————————————————————————————————————————————————————————————
enum DayOfWeek {
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
};




// 【Class 类型 - 🌟引用类型】 ————————————————————————————————————————————————————————————————
public class Cat {
	public string name { get; set; }
	public int age { get; set; }
}


var superCat = new Cat();
superCat.name = "John";
superCat.age = 25;

string smallCatName = superCat.name;
int smallCatAge = superCat.age;

Console.WriteLine($"CatName: {smallCatName}");
Console.WriteLine($"CatAge: {smallCatAge}");




// 【数组- 🌟引用类型(跟 C++不一样 !! C++ 的数组是值类型 !!)】 ————————————————————————————————————————————————————————————————
int[] arr = new int[3] {1, 2, 3}; // 声明一个数组, 长度为 3

// 👇访问数组
Console.WriteLine(arr.Length); // 访问数组长度, 注意这里是 L 大写！
Console.WriteLine(arr[0]); // 访问数组元素



// 【接口】 ————————————————————————————————————————————————————————————————
public interface ILogger {
	void Log(string message);
}

public class ConsoleLogger : ILogger {
	public void Log(string message) {
		Console.WriteLine(message);
	}
}

ILogger superLog = new ConsoleLogger();
superLog.Log("Log message~");



// 【委托】 ————————————————————————————————————————————————————————————————
delegate int Calculate(int x, int y); // 声明一个委托 (把方法当作一个参数来使用)
int Add(int x, int y) {  //某个方法（函数）
	return x + y;
}

Calculate superCal = Add; // 实例化一个委托
int result = superCal(1, 2); // 调用委托



// 【dynamic 动态类型】 任何类型的值都可以储存为动态数据类型变量中 => 在运行时才确定类型 => 类型不安全 ————————————————————————————————————————————————————————————————
dynamic totalAmount = 400;


// 【类型推断】 ————————————————————————————————————————————————————————————————
var someBody = 0; //自动推断类型 => int someBody = 0; => 静态类型, 编译阶段就确定





// namespace YourNamespace {
//     public partial class Program {
//         public static void Main() {
//             Cat superCat = new Cat();
//             superCat.name = "John";
//             superCat.age = 25;

//             string smallCatName = superCat.name;
//             int smallCatAge = superCat.age;

//             Console.WriteLine($"CatName: {smallCatName}");
//             Console.WriteLine($"CatAge: {smallCatAge}");

//             int[] arr = new int[3] {1, 2, 3};

//             Console.WriteLine(arr.Length);
//             Console.WriteLine(arr[0]);
//         }
//     }
// }

