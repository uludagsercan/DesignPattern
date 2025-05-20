using DesignPattern.Strategy.Abstracts;

namespace DesignPattern.Strategy.Concretes.CompressionStrategy
{
    public class RarCompressionStrategy : ICompressionStrategy
    {
        public void Compress(string filePath)
        {
            // Implementation for RAR compression
            Console.WriteLine($"Compressing {filePath} using RAR compression.");
        }
    }
}