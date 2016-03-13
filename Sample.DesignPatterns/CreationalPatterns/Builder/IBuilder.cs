namespace Sample.DesignPatterns.CreationalPatterns.Builder
{
    public interface IBuilder<out T>
    {
         T Build();
    }
}