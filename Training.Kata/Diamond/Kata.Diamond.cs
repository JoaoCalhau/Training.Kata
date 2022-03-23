namespace Training.Kata.Diamond
{
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Jamie is a programmer, and James' girlfriend. 
    /// She likes diamonds, and wants a diamond string from James. 
    /// Since James doesn't know how to make this happen, he needs your help.
    /// 
    /// Task
    /// You need to return a string that looks like a diamond shape when printed on the screen,
    /// using asterisk (*) characters.Trailing spaces should be removed,
    /// and every line must be terminated with a newline character (\n).
    /// 
    /// Return null/nil/None/... if the input is an even number or negative,
    /// as it is not possible to print a diamond of even or negative size.
    /// 
    /// Examples
    /// 
    /// A size 3 diamond:
    ///  *
    /// ***
    ///  *
    /// ...which would appear as a string of " *\n***\n *\n"
    /// 
    /// A size 5 diamond:
    ///   *
    ///  ***
    /// *****
    ///  ***
    ///   *
    /// ...that is:
    /// "  *\n ***\n*****\n ***\n  *\n"
    /// </summary>
    public class Kata
    {
        public static string print(int n)
        {
            if (n < 0 || n % 2 == 0)
            {
                return null;
            }

            var middle = n / 2;
            var sb = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                sb.Append(' ', Math.Abs(middle - i));
                sb.Append('*', Math.Abs(middle - i) * 2);
                sb.Append("\n");
            }

            return sb.ToString();
        }

        public static string print_MostRatedSolution(int n)
        {
            return n % 2 == 1
                   ? Enumerable.Range(0, n)
                     .Select(q =>
                        q <= n / 2
                        ? new string(' ', (n / 2 - q)) + new string('*', q * 2 + 1)
                        : new string(' ', (q - n / 2)) + new string('*', 2 * (n - q) - 1))
                     .Aggregate("", (c, i) => c + i + "\n")
                   : null;
        }
    }
}
