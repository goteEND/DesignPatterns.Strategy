using System.Linq.Expressions;

namespace DesignPatterns.Strategy.V1.BurgerFactory;

public class Context : IContext
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy<T>(IQueryable<T> src, Expression<Func<T, bool>> predicate)
    {
        _strategy.GenerateQuerry(src, predicate);
    }
}