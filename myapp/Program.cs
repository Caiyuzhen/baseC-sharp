using System;
/* 
	每个文件包含多个命名空间
		每个命名空间包含【类】、【结构】、【接口】、【枚举】、【委托】等类型或其他命名空间
 */


/// <summary>
/// 文档注释
/// </summary>
/// 

#region 
// 折叠代码快
#endregion


// 命名空间
namespace Hey {
	// 类型
	class Program { // 🚀 起始类 C# 9 之前, C#9 之后不用写了
		static void Main(string[] args) { // 🚀 起始函数 C#9 之前, C#9 之后不用写了
			int a = 100;
			int n = 200;
			int sum = 0;
			sum = a + n;

			string name = "Hello";

			System.Console.WriteLine(sum); //打印输出
			System.Console.ReadKey(); //接收用户的键盘输入
		}
	}
	

	struct Struc1 {

	}

	interface ImyInterface1 {

	}

	enum MyEnum {

	}

	namespace SubNameSpace {
		// ...
	}
}