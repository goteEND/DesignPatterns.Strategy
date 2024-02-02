using System.Linq.Expressions;

namespace DesignPatterns.Strategy.V1.BurgerFactory;

public interface IStrategy
{
    void GenerateQuerry<T>(IQueryable<T> src, Expression<Func<T, bool>> predicate);
}