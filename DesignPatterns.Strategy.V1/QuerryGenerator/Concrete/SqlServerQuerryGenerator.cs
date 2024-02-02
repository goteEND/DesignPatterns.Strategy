using System.Linq.Expressions;

namespace DesignPatterns.Strategy.V1.BurgerFactory.Concrete;

public class SqlServerQuerryGenerator : IStrategy
{
  public void GenerateQuerry<T>(IQueryable<T> src, Expression<Func<T, bool>> predicate)
  {
    Console.WriteLine("SqlServer querry generated");
  }
}
