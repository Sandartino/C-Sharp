using System;
public class Program
{
   public static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        string number = Convert.ToString(input, 2).PadLeft(16, '0');
        char[] arr = number.ToCharArray();
        char[] arrNew = new char[16];
        if(arr.Length>16)
        {
            int razlika = arr.Length - 16;
            for (int i = 0; i < 16; i++)
            {
                arrNew[i] = arr[razlika];
                razlika++;
            }
        }
        else
        {
            arrNew = arr;
        }
        string hash = "#";
        string dot = ".";  
   
            for (int k = 0; k < 16; k++)
            {
                if(arrNew[k]=='1')
                {
                    if (k == 15)
                    {
                        Console.Write(dot + hash + dot);
                        break;
                    }
                    else
                    {
                        Console.Write(dot + hash + dot + dot);
                        continue;
                    }
                }
                if(k==15)
                {
                    Console.Write(hash+hash+hash);
                    break;
                }
                Hashs();               
            }
            Console.WriteLine();
            for (int i = 0; i < 16; i++)
            {
                if(arrNew[i]=='1')
                {
                    if (i == 15)
                    {
                        Console.Write(hash + hash + dot);
                        break;
                    }
                    else
                    {
                        Console.Write(hash + hash + dot + dot);
                        continue;
                    }
                }
                if (i == 15)
                {
                    Console.Write(hash + dot + hash);
                    break;
                }
                HashDot();
            }
            Console.WriteLine();
            for (int q = 0; q < 2; q++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if(arrNew[j]=='1')
                    {
                        if (j == 15)
                        {
                            Console.Write(dot + hash + dot);
                            break;
                        }
                        else
                        {
                            Console.Write(dot + hash + dot + dot);
                            continue;
                        }
                    }
                    if (j == 15)
                    {
                        Console.Write(hash+dot+hash);
                        break;
                    }
                    HashDot();
                   
                }
                Console.WriteLine();
            }
            for (int k = 0; k < 16; k++)
            {
                if (k == 15)
                {
                    Console.Write(hash + hash + hash);
                    break;
                }
                Hashs();
            }
       
    }
  static void Hashs()
    {
        string hash = "#";
        string dot = ".";     
        string hashs = new string('#', 3);
        Console.Write(hashs + dot);  
    }
    static void HashDot()
  {
      string hash = "#";
      string dot = ".";
      Console.Write(hash+dot+hash+dot);
  }
}


