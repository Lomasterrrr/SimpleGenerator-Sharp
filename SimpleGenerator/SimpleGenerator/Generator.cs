using System.Text;

namespace SimpleGenerator
{
    public class SimpleGenerate
    {
        public string chars = "";
        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();
        public string GenerateString(string letterCase, int length)
        {

            if (letterCase == "a")
            {
                chars = "abcdefghijklmnopqrstuvwxyz";
            }
            else if (letterCase == "A")
            {
                chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (letterCase == "aA")
            {
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (letterCase == "1")
            {
                chars = "0123456789";
            }
            else if (letterCase == "a1")
            {
                chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            }
            else if (letterCase == "A1")
            {
                chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (letterCase == "aA1")
            {
                chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (letterCase == "~")
            {
                chars = "~!@#$%^&*()_+-=|/.<";
            }
            else if (letterCase == "~a")
            {
                chars = "abcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+-=|/.<";
            }
            else if (letterCase == "~aA")
            {
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*()_+-=|/.<";
            }
            else if (letterCase == "~aA1")
            {
                chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*()_+-=|/.<";
            }
            else
            {
                chars = letterCase;
            }

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }
            return sb.ToString();
        }
    }
}