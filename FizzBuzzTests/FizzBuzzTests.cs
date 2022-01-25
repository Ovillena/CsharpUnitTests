using System;
using FizzBuzzLibrary;
using Xunit;

namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Fact]
    public void Given2Result12()
    {
        FizzBuzz fb = new FizzBuzz();
        string expected = "1 2 ";
        string actual = fb.GetResult(2);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given4Result12Jizz4()
    {
        FizzBuzz fb = new FizzBuzz();
        string expected = "1 2 jizz 4 ";
        string actual = fb.GetResult(4);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given5Result12Jizz4Butt()
    {
        FizzBuzz fb = new FizzBuzz();
        string expected = "1 2 jizz 4 butt ";
        string actual = fb.GetResult(5);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given55Result12Jizz4ButtJizz78JizzButt11Jizz1314Butt()
    {
        FizzBuzz fb = new FizzBuzz();
        string expected = "1 2 jizz 4 butt jizz 7 8 jizz butt 11 jizz 13 14 jizzbutt ";
        string actual = fb.GetResult(15);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GivenMoreThan100ThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(101);
        Assert.Throws<Exception>(act);
    }

    [Fact]
    public void GivenLessThan0ThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(-1);
        Assert.Throws<Exception>(act);
    }
}