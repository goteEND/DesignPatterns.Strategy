using System.Linq.Expressions;

namespace DesignPatterns.Strategy.V1.BurgerFactory.Concrete;

public class TSqlQuerryGenerator : IStrategy
{
  public void GenerateQuerry<T>(IQueryable<T> src, Expression<Func<T, bool>> predicate)
  {
    Console.WriteLine("T-Sql querry generated");
  }
}