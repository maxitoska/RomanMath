using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanMath.Impl
{
	public static class Service
	{
		enum Roman 
        {
			M = 1000,
			D = 500,
			C = 100,
			L = 50,
			X = 10,
			V = 5,
			I = 1
		};
		/// <summary>
		 /// See TODO.txt file for task details.
		 /// Do not change contracts: input and output arguments, method name and access modifiers
		 /// </summary>
		 /// <param name="expression"></param>
		 /// <returns></returns>

		public static int Evaluate(string expression)
		{
			
			Validate(expression);

			Roman roman = new Roman();

			int values = 0;

			//Нужно както сравнить Enum с каждым символом в выражении expression , при этом придав заменив их значениеями 
			           			
			if (expression.Contains(Convert.ToString(roman)))
			{
				for (int i = 0; i < expression.Length; i++)
				{
					// values = ...
				}

			}
			return values;
			
		}

        private static void Validate(string expression)
        {
			Exception ex = new Exception("the input expression is invalid");

			
			if (expression.IsNullOrEmpty())
            {
				throw ex;
            }
			else if (expression.Contains("/"))
            {
				throw ex;
			}
			else if (expression.Contains("%"))
			{
				throw ex;
			}
			
		}

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
		{
			if (enumerable == null)
			{
				return true;
			}
			/* If this is a list, use the Count property for efficiency. 
			 * The Count property is O(1) while IEnumerable.Count() is O(N). */
			var collection = enumerable as ICollection<T>;
			if (collection != null)
			{
				return collection.Count < 1;
			}
			return !enumerable.Any();
		}


	}
	
	


}
