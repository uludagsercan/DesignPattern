using DesignPattern.Strategy.Abstracts;

namespace DesignPattern.Strategy.Concretes.Contexts
{
    public class CompressionContext
    {
        private readonly ICompressionStrategy _compressionStrategy;

        public CompressionContext(ICompressionStrategy compressionStrategy)
        {
            _compressionStrategy = compressionStrategy;
        }

        public void CompressFile(string filePath)
        {
            _compressionStrategy.Compress(filePath);
        }
    }
}