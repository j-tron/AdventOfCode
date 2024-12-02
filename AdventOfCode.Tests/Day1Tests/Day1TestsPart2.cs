﻿using Shouldly;

namespace AdventOfCode.Tests.Day1;


public class Day1TestsPart2
{
    [Fact]
    public void Day1_OnZero_ReturnsZero()
    {
        //Arrange
        var expected = 0;

        //Act
        var actual = AdventOfCode2024.Day1.Day1.SolutionPart2([], []);

        //Assert
        expected.ShouldBe(actual);
    }

    [Fact]
    public void Day1_OnGivenInput_ReturnsExpected()
    {
        //Arrange
        var expected = 31;
        int[] left = [3, 4, 2, 1, 3, 3];
        int[] right = [4, 3, 5, 3, 9, 3];

        //Act
        var actual = AdventOfCode2024.Day1.Day1.SolutionPart2(left, right);

        //Assert
        actual.ShouldBe(expected);
    }

    [Fact]
    public void Day1_WhenReadingTestFile_ReturnsExpected()
    {
        //Arrange
        var expected = 31;        

        //Act
        var (left, right) = AdventOfCode2024.Day1.Day1.ReadInput("Day1Tests/TestInput.txt");
        var actual = AdventOfCode2024.Day1.Day1.SolutionPart2(left, right);

        //Assert
        actual.ShouldBe(expected);
    }

    [Fact]
    public void Day1_WhenReadingRealFile_ReturnsExpected()
    {
        //Arrange
        var expected = 19097157;

        //Act
        var (left, right) = AdventOfCode2024.Day1.Day1.ReadInput("Day1Tests/RealInput.txt");
        var actual = AdventOfCode2024.Day1.Day1.SolutionPart2(left, right);

        //Assert
        actual.ShouldBe(expected);
    }
}