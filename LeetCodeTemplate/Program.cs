
public class LeetCodeTemplate
{


    public static void Main()
    {
        string input = " joyboy";

        Problem(input);

        return;


    }


    public static int Problem(string input)
    {
        if (input == null)
            return 0;
        if (input.Length == 0 || input.Length > Math.Pow(10, 4))
            return 0;

        char[] array = input.ToCharArray();

        int counter = 0;
        int lastCounter = counter;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == ' ' || array[i] == '\t')
            {
                if (counter > 0)
                    lastCounter = counter;
                counter = 0;
                continue;
            }

            counter++;
        }





        return counter > 0 ? counter : lastCounter;
    }





} // EOC
