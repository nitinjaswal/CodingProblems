public class SolutionSkipCharacterOrString
{
    public void Method()
    {

        string s = RemoveString("bacdapplefg");

    }
    private static string RemoveString(string originalString)
    {
        if (string.IsNullOrEmpty(originalString))
        {
            return "";
        }


        if (originalString.StartsWith("apple"))
        {
            return RemoveString(originalString.Substring(5));//skipping complete apple string from original string
        }
        else
        {
            return originalString.Substring(0, 1) + RemoveString(originalString.Substring(1));
        }

    }

    private static string RemoveChar(string originalString)
    {
        if (string.IsNullOrEmpty(originalString))
        {
            return "";
        }

        string ch = originalString.Substring(0, 1);

        if (ch == "a")
        {
            return RemoveChar(originalString.Substring(1));
        }
        else
        {
            return ch + RemoveChar(originalString.Substring(1));
        }

    }
}
