using BenchmarkDotNet.Attributes;

namespace Test;

[MemoryDiagnoser]
public class Benchmark
{
    public Record1 Record1 = new(default);
    public RecordStruct1 RecordStruct1 = default;
    public RecordStructReadonly1 RecordStructReadonly1 = default;
    public Record5 Record5 = new(default, default, default, default, default);
    public RecordStruct5 RecordStruct5 = default;
    public RecordStructReadonly5 RecordStructReadonly5 = default;
    public Record8 Record8 = new(default, default, default, default, default, default, default, default);
    public RecordStruct8 RecordStruct8 = default;
    public RecordStructReadonly8 RecordStructReadonly8 = default;
    public Record13 Record13 = new(default, default, default, default, default, default, default, default, default, default, default, default, default);
    public RecordStruct13 RecordStruct13 = default;
    public RecordStructReadonly13 RecordStructReadonly13 = default;

    [GlobalSetup]
    public void GlobalSetup()
    {

    }

    [Benchmark]
    public Record1 Record1WithAll()
        => Record1 with
        {
            P0 = 1
        };
    

    [Benchmark]
    public Record1 Record1ConstructorAll()
        => new(
            1);
    

    [Benchmark]
    public RecordStruct1 RecordStruct1WithAll()
        => RecordStruct1 with
        {
            P0 = 1
        };
    

    [Benchmark]
    public RecordStruct1 RecordStruct1ConstructorAll()
        => new(
            1);
    

    [Benchmark]
    public RecordStructReadonly1 RecordStructReadonly1WithAll()
        => RecordStructReadonly1 with
        {
            P0 = 1
        };
    

    [Benchmark]
    public RecordStructReadonly1 RecordStructReadonly1ConstructorAll()
        => new(
            1);
    

    [Benchmark]
    public Record5 Record5WithHalf()
        => Record5 with
        {
            P0 = 1,
            P1 = 2
        };
    

    [Benchmark]
    public Record5 Record5WithDense()
        => Record5 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4
        };
    

    [Benchmark]
    public Record5 Record5WithAll()
        => Record5 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5
        };
    

    [Benchmark]
    public Record5 Record5ConstructorHalf()
        => new(
            1,
            2,
            Record5.P2,
            Record5.P3,
            Record5.P4);
    

    [Benchmark]
    public Record5 Record5ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            Record5.P4);
    

    [Benchmark]
    public Record5 Record5ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5);
    

    [Benchmark]
    public RecordStruct5 RecordStruct5WithHalf()
        => RecordStruct5 with
        {
            P0 = 1,
            P1 = 2
        };
    

    [Benchmark]
    public RecordStruct5 RecordStruct5WithDense()
        => RecordStruct5 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4
        };
    

    [Benchmark]
    public RecordStruct5 RecordStruct5WithAll()
        => RecordStruct5 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5
        };
    

    [Benchmark]
    public RecordStruct5 RecordStruct5ConstructorHalf()
        => new(
            1,
            2,
            RecordStruct5.P2,
            RecordStruct5.P3,
            RecordStruct5.P4);
    

    [Benchmark]
    public RecordStruct5 RecordStruct5ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            RecordStruct5.P4);
    

    [Benchmark]
    public RecordStruct5 RecordStruct5ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5);
    

    [Benchmark]
    public RecordStructReadonly5 RecordStructReadonly5WithHalf()
        => RecordStructReadonly5 with
        {
            P0 = 1,
            P1 = 2
        };
    

    [Benchmark]
    public RecordStructReadonly5 RecordStructReadonly5WithDense()
        => RecordStructReadonly5 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4
        };
    

    [Benchmark]
    public RecordStructReadonly5 RecordStructReadonly5WithAll()
        => RecordStructReadonly5 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5
        };
    

    [Benchmark]
    public RecordStructReadonly5 RecordStructReadonly5ConstructorHalf()
        => new(
            1,
            2,
            RecordStructReadonly5.P2,
            RecordStructReadonly5.P3,
            RecordStructReadonly5.P4);
    

    [Benchmark]
    public RecordStructReadonly5 RecordStructReadonly5ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            RecordStructReadonly5.P4);
    

    [Benchmark]
    public RecordStructReadonly5 RecordStructReadonly5ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5);
    

    [Benchmark]
    public Record8 Record8WithHalf()
        => Record8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4
        };
    

    [Benchmark]
    public Record8 Record8WithDense()
        => Record8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6
        };
    

    [Benchmark]
    public Record8 Record8WithAll()
        => Record8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8
        };
    

    [Benchmark]
    public Record8 Record8ConstructorHalf()
        => new(
            1,
            2,
            3,
            4,
            Record8.P4,
            Record8.P5,
            Record8.P6,
            Record8.P7);
    

    [Benchmark]
    public Record8 Record8ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            Record8.P6,
            Record8.P7);
    

    [Benchmark]
    public Record8 Record8ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8);
    

    [Benchmark]
    public RecordStruct8 RecordStruct8WithHalf()
        => RecordStruct8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4
        };
    

    [Benchmark]
    public RecordStruct8 RecordStruct8WithDense()
        => RecordStruct8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6
        };
    

    [Benchmark]
    public RecordStruct8 RecordStruct8WithAll()
        => RecordStruct8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8
        };
    

    [Benchmark]
    public RecordStruct8 RecordStruct8ConstructorHalf()
        => new(
            1,
            2,
            3,
            4,
            RecordStruct8.P4,
            RecordStruct8.P5,
            RecordStruct8.P6,
            RecordStruct8.P7);
    

    [Benchmark]
    public RecordStruct8 RecordStruct8ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            RecordStruct8.P6,
            RecordStruct8.P7);
    

    [Benchmark]
    public RecordStruct8 RecordStruct8ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8);
    

    [Benchmark]
    public RecordStructReadonly8 RecordStructReadonly8WithHalf()
        => RecordStructReadonly8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4
        };
    

    [Benchmark]
    public RecordStructReadonly8 RecordStructReadonly8WithDense()
        => RecordStructReadonly8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6
        };
    

    [Benchmark]
    public RecordStructReadonly8 RecordStructReadonly8WithAll()
        => RecordStructReadonly8 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8
        };
    

    [Benchmark]
    public RecordStructReadonly8 RecordStructReadonly8ConstructorHalf()
        => new(
            1,
            2,
            3,
            4,
            RecordStructReadonly8.P4,
            RecordStructReadonly8.P5,
            RecordStructReadonly8.P6,
            RecordStructReadonly8.P7);
    

    [Benchmark]
    public RecordStructReadonly8 RecordStructReadonly8ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            RecordStructReadonly8.P6,
            RecordStructReadonly8.P7);
    

    [Benchmark]
    public RecordStructReadonly8 RecordStructReadonly8ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8);
    

    [Benchmark]
    public Record13 Record13WithSparse()
        => Record13 with
        {
            P0 = 1
        };
    

    [Benchmark]
    public Record13 Record13WithHalf()
        => Record13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6
        };
    

    [Benchmark]
    public Record13 Record13WithDense()
        => Record13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8,
            P8 = 9,
            P9 = 10
        };
    

    [Benchmark]
    public Record13 Record13WithAll()
        => Record13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8,
            P8 = 9,
            P9 = 10,
            P10 = 11,
            P11 = 12,
            P12 = 13
        };
    

    [Benchmark]
    public Record13 Record13ConstructorSparse()
        => new(
            1,
            Record13.P1,
            Record13.P2,
            Record13.P3,
            Record13.P4,
            Record13.P5,
            Record13.P6,
            Record13.P7,
            Record13.P8,
            Record13.P9,
            Record13.P10,
            Record13.P11,
            Record13.P12);
    

    [Benchmark]
    public Record13 Record13ConstructorHalf()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            Record13.P6,
            Record13.P7,
            Record13.P8,
            Record13.P9,
            Record13.P10,
            Record13.P11,
            Record13.P12);
    

    [Benchmark]
    public Record13 Record13ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            Record13.P10,
            Record13.P11,
            Record13.P12);
    

    [Benchmark]
    public Record13 Record13ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13);
    

    [Benchmark]
    public RecordStruct13 RecordStruct13WithSparse()
        => RecordStruct13 with
        {
            P0 = 1
        };
    

    [Benchmark]
    public RecordStruct13 RecordStruct13WithHalf()
        => RecordStruct13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6
        };
    

    [Benchmark]
    public RecordStruct13 RecordStruct13WithDense()
        => RecordStruct13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8,
            P8 = 9,
            P9 = 10
        };
    

    [Benchmark]
    public RecordStruct13 RecordStruct13WithAll()
        => RecordStruct13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8,
            P8 = 9,
            P9 = 10,
            P10 = 11,
            P11 = 12,
            P12 = 13
        };
    

    [Benchmark]
    public RecordStruct13 RecordStruct13ConstructorSparse()
        => new(
            1,
            RecordStruct13.P1,
            RecordStruct13.P2,
            RecordStruct13.P3,
            RecordStruct13.P4,
            RecordStruct13.P5,
            RecordStruct13.P6,
            RecordStruct13.P7,
            RecordStruct13.P8,
            RecordStruct13.P9,
            RecordStruct13.P10,
            RecordStruct13.P11,
            RecordStruct13.P12);
    

    [Benchmark]
    public RecordStruct13 RecordStruct13ConstructorHalf()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            RecordStruct13.P6,
            RecordStruct13.P7,
            RecordStruct13.P8,
            RecordStruct13.P9,
            RecordStruct13.P10,
            RecordStruct13.P11,
            RecordStruct13.P12);
    

    [Benchmark]
    public RecordStruct13 RecordStruct13ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            RecordStruct13.P10,
            RecordStruct13.P11,
            RecordStruct13.P12);
    

    [Benchmark]
    public RecordStruct13 RecordStruct13ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13);

    [Benchmark]
    public RecordStructReadonly13 RecordStructReadonly13WithSparse()
        => RecordStructReadonly13 with
        {
            P0 = 1
        };

    [Benchmark]
    public RecordStructReadonly13 RecordStructReadonly13WithHalf()
        => RecordStructReadonly13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6
        };

    [Benchmark]
    public RecordStructReadonly13 RecordStructReadonly13WithDense()
        => RecordStructReadonly13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8,
            P8 = 9,
            P9 = 10
        };

    [Benchmark]
    public RecordStructReadonly13 RecordStructReadonly13WithAll()
        => RecordStructReadonly13 with
        {
            P0 = 1,
            P1 = 2,
            P2 = 3,
            P3 = 4,
            P4 = 5,
            P5 = 6,
            P6 = 7,
            P7 = 8,
            P8 = 9,
            P9 = 10,
            P10 = 11,
            P11 = 12,
            P12 = 13
        };

    [Benchmark]
    public RecordStructReadonly13 RecordStructReadonly13ConstructorSparse()
        => new(
            1,
            RecordStructReadonly13.P1,
            RecordStructReadonly13.P2,
            RecordStructReadonly13.P3,
            RecordStructReadonly13.P4,
            RecordStructReadonly13.P5,
            RecordStructReadonly13.P6,
            RecordStructReadonly13.P7,
            RecordStructReadonly13.P8,
            RecordStructReadonly13.P9,
            RecordStructReadonly13.P10,
            RecordStructReadonly13.P11,
            RecordStructReadonly13.P12);

    [Benchmark]
    public RecordStructReadonly13 RecordStructReadonly13ConstructorHalf()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            RecordStructReadonly13.P6,
            RecordStructReadonly13.P7,
            RecordStructReadonly13.P8,
            RecordStructReadonly13.P9,
            RecordStructReadonly13.P10,
            RecordStructReadonly13.P11,
            RecordStructReadonly13.P12);

    [Benchmark]
    public RecordStructReadonly13 RecordStructReadonly13ConstructorDense()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            RecordStructReadonly13.P10,
            RecordStructReadonly13.P11,
            RecordStructReadonly13.P12);

    [Benchmark]
    public RecordStructReadonly13 RecordStructReadonly13ConstructorAll()
        => new(
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13);
}

public record Record1(int P0);
public record struct RecordStruct1(int P0);
public readonly record struct RecordStructReadonly1(int P0);
public record Record5(int P0, int P1, int P2, int P3, int P4);
public record struct RecordStruct5(int P0, int P1, int P2, int P3, int P4);
public readonly record struct RecordStructReadonly5(int P0, int P1, int P2, int P3, int P4);
public record Record8(int P0, int P1, int P2, int P3, int P4, int P5, int P6, int P7);
public record struct RecordStruct8(int P0, int P1, int P2, int P3, int P4, int P5, int P6, int P7);
public readonly record struct RecordStructReadonly8(int P0, int P1, int P2, int P3, int P4, int P5, int P6, int P7);
public record Record13(int P0, int P1, int P2, int P3, int P4, int P5, int P6, int P7, int P8, int P9, int P10, int P11, int P12);
public record struct RecordStruct13(int P0, int P1, int P2, int P3, int P4, int P5, int P6, int P7, int P8, int P9, int P10, int P11, int P12);
public readonly record struct RecordStructReadonly13(int P0, int P1, int P2, int P3, int P4, int P5, int P6, int P7, int P8, int P9, int P10, int P11, int P12);