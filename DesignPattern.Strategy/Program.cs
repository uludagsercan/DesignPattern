

using DesignPattern.Strategy.Abstracts;
using DesignPattern.Strategy.Concretes.CompressionStrategy;
using DesignPattern.Strategy.Concretes.Contexts;

ICompressionStrategy compressionStrategy = new RarCompressionStrategy();
CompressionContext compressionContext = new CompressionContext(compressionStrategy);
compressionContext.CompressFile("rarexample.txt");

ICompressionStrategy zipCompressionStrategy = new ZipCompressionStrategy();
CompressionContext zipCompressionContext = new CompressionContext(zipCompressionStrategy);
zipCompressionContext.CompressFile("zipexample.txt");