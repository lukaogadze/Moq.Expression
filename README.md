# Moq.Expression
This package helps you to solve expression function in unit test moq framework.

### Download
The latest stable release is available on NuGet: https://www.nuget.org/packages/MoqExpression/

#### Example
`Install-Package MoqExpression -Version 1.0.0`

**IUserService**

    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
    }

    public interface IUserService
    {
        User FindByUserId(Expression<Func<User, bool>> expression);
    }

**UnitTest**

    using MoqExpression;

    User user = new User();
    Mock<IUserService> mockUserService = new Mock<IUserService>();
    mockUserService.Setup(x => x.FindByUserId(MoqHelper.IsExpression<User>(s => s.UserId.Equals("123")))).Returns(user);

**Note: Make sure don't use like this, it will not work.**

    // don't use like this it will not work 
    Expression<Func<User, bool>> expression = MoqHelper.IsExpression<User>(s => s.UserId.Equals("123"));
    mockUserService.Setup(x => x.FindByUserId(expression)).Returns(user);

    // use equal function instead of ==
    mockUserService.Setup(x => x.FindByUserId(MoqHelper.IsExpression<User>(s => s.UserId == "123"))).Returns(user);
    
