
using System.Text;

public class LeetCodeTemplate
{


    public static void Main()
    {

        string input = "Hello";

        Console.WriteLine(Problem(input));

        return;


    }


    public static string Problem(string s)
    {
        if (s == null)
            return "";

        if (0 > s.Length || s.Length > 100)
            return "";

        byte[] asciiBytes = Encoding.ASCII.GetBytes(s);


        for(int i = 0; i < asciiBytes.Length; i++)
        {
            if (64 < asciiBytes[i] && asciiBytes[i] < 91)
            {
                asciiBytes[i] += 26 + 6;
            }   
        }



        return Encoding.ASCII.GetString(asciiBytes);
    }





} // EOC
