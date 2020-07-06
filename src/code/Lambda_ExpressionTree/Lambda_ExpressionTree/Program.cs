using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_ExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 * 2 + ( x - y )
            Expression const1 = Expression.Constant(1);
            Expression const2 = Expression.Constant(2);
            // 1 * 2
            Expression leftExp = Expression.Multiply(const1, const2);

            // x를 위한 변수
            Expression param1 = Expression.Parameter(typeof(int));
            // y를 위한 변수
            Expression param2 = Expression.Parameter(typeof(int));
            // x - y
            Expression rightExp = Expression.Subtract(param1, param2);

            // 1 * 2 와 x - y 식 추가
            Expression exp = Expression.Add(leftExp, rightExp);

            Expression<Func<int, int, int>> expression =
                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                    exp,
                    new ParameterExpression[]
                    {
                        (ParameterExpression) param1,
                        (ParameterExpression) param2
                    }
                );

            // 실행가능한 코드로 컴파일
            Func<int, int, int> func = expression.Compile();

            // x = 7, y = 8
            Console.WriteLine($"1 * 2 + ({7} - {8}) = {func(7, 8)}");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Expression<Func<int, int, int>> expression2 = (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func2 = expression.Compile();

            Console.WriteLine($"1 * 2 + ({7} - {8}) = {func2(7, 8)}");
        }
    }
}
