#region main

#region parameters
//int x = 8;
//int y = 6;
//opertaion.swap(x, y);// by that i pass values 

//Console.WriteLine($"x={x},y={y}");// x= 8, y=6

//int x1 = 8;
//int y1 = 6;
//opertaion.swap(ref x1, ref y1);// by that i pass refernce 

//Console.WriteLine($"x={x1},y={y1}"); //x=6 , y=8 

//int[] array1 = { 1, 2, 3, 4 };
//int[] array2 = {  5, 6, 7 };
//// size doesn't matter datatype matter 
//opertaion.swap(array1, array2);//swap will not  happen 

//for (int i = 0; i < array1.Length; i++)
//{
//    Console.WriteLine(array1[i]);
//}

//opertaion.swap(ref array1, ref array2);//swap will  happen 

//for (int i = 0; i < array1.Length; i++)
//{
//    Console.WriteLine(array1[i]);
//}

//opertaion.add(array1);// adding will happen
//for (int i = 0; i < array1.Length; i++)
//{
//    Console.WriteLine(array1[i]);
//}

//int mul = 0, sub = 0, division;
//int sum = opertaion.calc(5, 3, out mul, out sub,out division);
// Console.WriteLine($"sum mul={mul},sum={sum}");

using System.Numerics;

operataion.sum(2, 3, 4, 5);//14
operataion.sum(2, 3);// 5

//student s1 = new student();
//student s2 = new student(1);
//student s3 = new student(1,"ali");
//student s4 = new student(1,"ali",20);
//student s5 = new student(age:20);//named parameter 
//student s6 = new student(name:"ali");//named parameter 
//student s7 = new student(age:20,id:1);//named parameter 
//student s8 = new student(id:2,age:20);//named parameter 
//student s9 = new student(id:1,age:20,name:"ali");//named parameter 

#endregion
#region operator overload 

//student s = new student(1, "ali", 20);
//student s1 = new student(1, "ali", 20);
//if(s == s1)// equal will not work here because equal here comapre data in stack not heap so we need to change behavir 
//{

//}
//student s2 = new student(1, "ali", 20);
//student s3 = new student(2, "mostafa", 22);
//if (s2 > s3)// binary operator will work beacuse we used operator overload
//{
//    Console.WriteLine($"{s2.name} is older than {s3.name} ");

//}else
//{
//    Console.WriteLine($"{s2.name} is older than {s3.name} ");
//}

//complex c= new complex(1,3);
//complex c1= new complex(3,1);
//complex c2 = new complex();
//   c2= c + c1;
//Console.WriteLine(c2.getstring());
//c2++;
//Console.WriteLine(c2.getstring());

//casting

//student s = new student(id:1,name:"ali",age:22);
////int x = s;
//int x = (int)s;
//Console.WriteLine(x);
//string y = (string)s;
//Console.WriteLine(y);
#endregion
#region access modifier 

// their is six types of access modifier (1-public 2-private 3-protected 4-internal 5- protected internal 6-privated protected )
// defualt for member is private 
// defualt for class and continaers is internal
// the degree of container must be higher than members  
#endregion

#endregion







#region parameters

//class student
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public int age { get; set; }

//    public student(int id =0, string name="" , int age=6)//defualt parameter "هنا انا طبقت كل احتمالات ال constractor"
//    {
//        this.id = id;
//        this.name = name;
//        this.age = age;

//    }
//}

class operataion
{

    public static int sum(int x , int y, int z=0,int w=0) //default parameter
    {
        return x + y+z+w;
    }
    //public static int calc( int x,  int y, out int mul, out int sub,out int division)//output parameter
    //{
    //    division = x / y;
    //    mul = x * y;
    //    sub = x - y;
    //    return x + y;

    //    // function have more than one output; using output
    //}
    //public static int calc(int x,int y, ref int mul , ref int sub)
    //{
    //    mul = x * y;
    //    sub = x - y;
    //    return x + y;

    // function have more than one output; using ref'not main use'
    //}

    //public static void swap( int[] a,  int[] b)

    //{
    //    int[] temp = a;
    //    a = b;
    //    b = temp;
    //}
    //public static void swap(ref int[] a,ref  int[] b)

    //{
    //    int[] temp = a;
    //    a = b;
    //    b = temp;
    //}
    //public static void add(int[] a)
    //{
    //    for (int i = 0;i < a.Length; i++)
    //    {
    //        a[i] ++;
    //    }
    //}

    //public static void swap(ref int a, ref int b)

    //{
    //    int temp = a;
    //    a = b;
    //    b = temp;
    //    }
    //public static void swap(int a, int b)

    //{

    //    int temp = a;
    //    a = b;
    //    b = temp;
    //}
}
#endregion

#region operator overload 


struct complex
{
    public int real { get; set; }
    public int img { get; set; }

    public complex(int real = 0, int img = 0)
    {
        this.real = real;
        this.img = img;

    }
    public string getstring()
    {
        return $"{real}+{img}i";
    }

    public static complex operator + (complex c1 , complex c2)//binary operator
    {
        complex c = new complex();
        c.real= c1.real+c2.real;
        c.img= c1.img+c2.img;
        return c;

    }
    public static complex operator ++(complex c1)//uni operator
    {
        
        c1.real++;
        c1.img++;
        return c1;

    }
    public static complex operator +(complex c1, int c2)//binary operator "c2+=1"
    {
        complex c = new complex();
        c.real = c1.real + c2;
        c.img = c1.img;
        return c;

    }
   


}

class student
{
    public int id { get; set; }
    public int age { get; set; }
    public string name { get; set; }

    public student(int age =0,string name="", int id =0)
    {
        this.age = age;
        this.name = name;
         this.id = id;
    }
    public string gatstring()
    {
        return $"{id}--{name}\t\t{age} years old";
    }

    public static bool operator > (student s1,student s2) // binary opertaor 
    {
        return (s1.age > s2.age);
    }
    public static bool operator <(student s1, student s2) // binary opertaor 
    {
        return (s1.age < s2.age);
    }
    //public static implicit operator int(student s
    //{
    //    return s.id;
    //}
    public static explicit operator int(student s)
    {
        return s.id;
    }
    public static explicit operator string(student s)
    {
        return s.name;
    }
    // only one either impicit or explicit 
}
#endregion