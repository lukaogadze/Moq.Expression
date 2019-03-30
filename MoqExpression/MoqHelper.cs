using Moq;
using System;
using System.Linq.Expressions;

namespace MoqExpression
{
    public static class MoqHelper
    {
        public static Expression<Func<T, bool>> IsExpression<T>(Expression<Func<T, bool>> query)
        {
            return It.Is<Expression<Func<T, bool>>>(expression => LambdaCompare.Eq(expression, query));
        }
    }
}
