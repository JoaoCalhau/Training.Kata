namespace Training.Kata.Unique_In_Order
{
    using System.Linq;

    /// <summary>
    /// Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
    ///
    /// For example:
    /// uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
    /// uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
    /// uniqueInOrder([1,2,2,3,3])       == {1,2,3}
    /// 
    /// </summary>
    public class Kata
    {
        #region Unique In Order

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            return iterable.Where((item, index) => index == 0 || !Equals(item, iterable.ElementAt(index - 1)));
        }

        public static IEnumerable<T> UniqueInOrder_MostRatedSolution<T>(IEnumerable<T> iterable)
        {
            // CodeWars page went down when I was trying to submit my answer. rip :(
            yield return default(T);
        }

        #endregion
    }
}
