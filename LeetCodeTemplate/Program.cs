
public class LeetCodeTemplate
{


    public static void Main()
    {

        int[] nums = { 27664, 47570, 27664, 27664, 27664, 27664, 27664, 27664, 27664, 27664 };

        DateTime start = DateTime.Now;

        Problem(nums);

        Console.WriteLine( $"RunTime: {DateTime.Now - start}");
        return;

    }

    // array sort 

    


    public static int Problem(int[] nums)
    {
        if (nums.Length > (5 * Math.Pow(10, 4)))
        {
            return 0;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > (5 * Math.Pow(10, 4)))
                return 0;
        }

        int returnNum = 0;

        Array.Sort(nums);

        for(int i = nums.Length-1; i > 0; i--)
        {

            if (nums[i] != nums[i - 1])
            {

                returnNum += (nums.Length - i);
            }
        }




        

        return returnNum;
    }



} // EOC
