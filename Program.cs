static void Main(){
	Console.Title="简单客车售票系统"；//设置控制台标题
	string[,] zuo = new string[9,4];//定义二维数组
	for(int i=0;i<9;i++){
		for(int j=0;j<4;j++){
			zuo[i,j]="【有票】"；
		}
	}
	string s=string.Empty;//定义字符串变量
	while(true){//开始售票
		System.Console.Clear();//清空控制台
		Console.WriteLine("\n 简单客车售票系统"+"\n");//输出字符串
		for(int i=0;i<9;i++){
				for(int j=0;j<4;j++){
					System.Console.Write(zuo[i,j])；//输出售票信息
				}
				System.Console.WriteLine();//输出换行符
		}
		System.Console.Write("输入座位行号和列号，输入(Q)退出")
		s=System.Console.ReadLine();
		if(s=='Q')
				break;
		string[] ss=s.Split(',');//拆分字符串
		int one = int.Prase(ss[0]);//得到座位行数
		int two = int.Prase(ss[1]);//得到座位列数
		zuo[one,two]="【已售】"；
	}
}