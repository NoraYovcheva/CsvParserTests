using NUnit.Framework;
using System;
using System.Linq;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        //Arrange
        string input = string.Empty;
        string[] expected = Array.Empty<string> ();


        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //Arrange
        string input = " Nora " ;
        string[] expected = new string[] { "Nora"};


        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        //Arrange
        string input = " Nora , Krasimirova    ,  Yovcheva      ";
        string[] expected = new string[] { "Nora", "Krasimirova", "Yovcheva" };


        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        //Arrange
        string input = " Nora , Krasimirova    ,  Yovcheva   ,  Burgas   ";
        string[] expected = new string[] { "Nora", "Krasimirova", "Yovcheva", "Burgas" };


        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
