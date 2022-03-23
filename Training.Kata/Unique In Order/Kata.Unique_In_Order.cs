﻿namespace Training.Kata.Unique_In_Order
{
    using System.Linq;

    public class Kata
    {
        #region UniqueInOrder

        /// <summary>
        /// Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
        ///
        /// For example:
        /// uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
        /// uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
        /// uniqueInOrder([1,2,2,3,3])       == {1,2,3}
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iterable"></param>
        /// <returns></returns>
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {

        }

        public static IEnumerable<T> UniqueInOrder_MostRatedSolution<T>(IEnumerable<T> iterable)
        {

        }

        #endregion
    }
}
