using Moq;
using System;
using System.Linq.Expressions;

namespace MoqExpression
{
    public static class MoqHelper
    {
        /// <summary>
        /// Match expression function methods with lambda function.
        /// https://github.com/ovaishanif94/Moq.Expression
        /// </summary>
        /// <typeparam name="T">Type of class</typeparam>
        /// <param name="query">Parameters to match</param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> IsExpression<T>(Expression<Func<T, bool>> query)
        {
            return It.Is<Expression<Func<T, bool>>>(expression => LambdaCompare.Eq(expression, query));
        }
    }
}
