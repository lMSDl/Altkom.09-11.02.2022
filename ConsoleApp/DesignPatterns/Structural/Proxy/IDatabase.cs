using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Proxy
{
    public interface IDatabase
    {
        Task<int?> RequestAsync(int parameter);
    }
}