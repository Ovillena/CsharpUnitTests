namespace FizzBuzzLibrary;
public class FizzBuzz
{
    public string GetResult(int nmbr)
    {

        if (nmbr > 100)
        {
            throw new Exception("da number is too big, homnie. larger than 100");
        }

        if (nmbr < 0)
        {
            throw new Exception("da number is negative, homie.");

        }

        string result = "";
        for (int ndx = 1; ndx < nmbr + 1; ndx++)
        {
            if (ndx % 3 == 0 && ndx % 5 == 0)
            {
                result += "jizzbutt ";
            }
            else if (ndx % 3 == 0)
            {
                result += "jizz ";
            }
            else if (ndx % 5 == 0)
            {
                result += "butt ";
            }
            else
            {
                result += ndx.ToString() + " ";
            }
        }
        return result;
    }

}
