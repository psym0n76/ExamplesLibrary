﻿using System;
using System.Linq.Expressions;

namespace ExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //expression trees
            // uses are LINQ conversion
            //(10+20) - (5+3)

            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add,
                                                        Expression.Constant(10),
                                                        Expression.Constant(20));

            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add,
                                            Expression.Constant(5),
                                            Expression.Constant(3));

            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract,
                                                        b1,
                                                        b2);

            int result = Expression.Lambda<Func<int>>(b3).Compile()();

        }
    }
}
