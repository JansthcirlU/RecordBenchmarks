using Test;

#if RELEASE
    BenchmarkRunner.Run<Benchmark>();
#else
    Benchmark b = new();
    b.GlobalSetup();
#endif