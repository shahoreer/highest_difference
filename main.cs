using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        string quote = "\"";
    string[] a =   {"4518230","4518232","4518238","4518240","4518242","4518258","4518260","4518262","4518264","4518266","4518284","4518286","4518288","4518296","4518299","4518306","4518308","4518310","4518312","4518314"};
    
    string[] b = {"4518231","4518233","4518239","4518241","4518243","4518259","4518261","4518263","4518265","4518267","4518285","4518287","4518289","4518297","4518298","4518307","4518309","4518311","4518313","4518315"};

    string c="";
    
    for(int i=0;i<5;i++){
    	for(int j=0; j<20;j+=5){
         c += quote+a[i+j]+quote+",";
        }
    }
    Console.WriteLine("Apple:{"+c+"}");
    c="";
        for(int i=0;i<5;i++){
    	for(int j=0; j<20;j+=5){
         c += quote+b[i+j]+quote+",";
        }
    }
    Console.WriteLine("Android:{"+c+"}");       
    }
  }
}



