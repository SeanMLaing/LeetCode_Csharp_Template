
public class LeetCodeTemplate
{


    public static void Main(string[] args)
    {
        Console.WriteLine(Problem(args[0], args[1]));

        return;
    }


    public static string Problem(string word1, string word2)
    {
        string returnstring = "";


        if (word1.Length < 1 || word2.Length < 1)
        {
            return returnstring;
        }

        if (word1.Length > 100 || word2.Length > 100)
        {
            return returnstring;
        }
        

        // make into arrays, 
        char[] array1 = word1.ToCharArray();
        char[] array2 = word2.ToCharArray();

        int maxlength = array1.Length;
        if (array2.Length > maxlength) 
            maxlength = array2.Length;


        for(int i = 0; i < maxlength; i++)
        {
            if (i < array1.Length)
                returnstring += array1[i];

            if (i < array2.Length)
                returnstring += array2[i];
        }

        return returnstring.Replace(" ", "");
    }





} // EOC
