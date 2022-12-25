using System.Text;
using System;

namespace SimpleGenerator
{
    public class Main
    {
        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();
        public string chars = string.Empty;

        public string GenerateString(string letterCase, int length)
        {
            switch (letterCase)
            {
                case "a":
                    chars = "abcdefghijklmnopqrstuvwxyz";
                    break;
                case "A":
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case "aA":
                    chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case "1":
                    chars = "0123456789";
                    break;
                case "a1":
                    chars = "0123456789abcdefghijklmnopqrstuvwxyz";
                    break;
                case "A1":
                    chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case "aA1":
                    chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case "~":
                    chars = "~!@#$%^&*()_+-=|/.<";
                    break;
                case "~a":
                    chars = "abcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+-=|/.<";
                    break;
                case "~A":
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*()_+-=|/.<";
                    break;
                case "~aA":
                    chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*()_+-=|/.<";
                    break;
                case "~1":
                    chars = "0123456789~!@#$%^&*()_+-=|/.<";
                    break;
                case "~aA1":
                    chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*()_+-=|/.<";
                    break;
                default:
                    chars = letterCase;
                    break;
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