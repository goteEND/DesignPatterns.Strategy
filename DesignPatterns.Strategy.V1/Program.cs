using System.Linq.Expressions;
using DesignPatterns.Strategy.V1.BurgerFactory;
using DesignPatterns.Strategy.V1.BurgerFactory.Concrete;

namespace DesignPatterns.Strategy.V1;

class Program
{
    static void Main(string[] args)
    {
        IQueryable<Student> students = new List<Student>
        {
            new() { Name = "John", Age = 18 },
            new() { Name = "Jane", Age = 20 },
            new() { Name = "Doe", Age = 22 }
        }.AsQueryable();

        Expression<Func<Student, bool>> expression = s => s.Age > 20;

        Context querryGenerator = new();
        querryGenerator.SetStrategy(new MySqlQuerryGenerator());
        querryGenerator.ExecuteStrategy(students, expression);

        querryGenerator.SetStrategy(new SqlServerQuerryGenerator());
        querryGenerator.ExecuteStrategy(students, expression);

        querryGenerator.SetStrategy(new TSqlQuerryGenerator());
        querryGenerator.ExecuteStrategy(students, expression);

    }
}
