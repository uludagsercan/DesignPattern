using DesignPattern.Strategy.Abstracts;

namespace DesignPattern.Strategy.Concretes.CompressionStrategy
{
    public class ZipCompressionStrategy : ICompressionStrategy
    {
        public void Compress(string filePath)
        {
            // Implementation for ZIP compression
            Console.WriteLine($"Compressing {filePath} using ZIP compression.");
        }
    }
}