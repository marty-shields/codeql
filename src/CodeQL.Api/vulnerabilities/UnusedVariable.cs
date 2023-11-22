public class UnusedVariable
{
    public void Vulnerability()
    {
        int[] intArray = [1,2,3,4,5];

        // i in loop not used
        foreach (var i in intArray)
        {
            Console.WriteLine(intArray[0]);
        }
    }
}