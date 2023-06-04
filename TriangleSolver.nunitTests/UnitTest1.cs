namespace TriangleSolver.nunitTests;

public class Tests
{
    private  Triangle triangleSolver{ get; set; } = null!;

    [SetUp]
    public void Setup()
    {
        triangleSolver = new Triangle();
    }

    [Test]
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange
        int firstSide = 20;
        int secondSide = 20;
        int thirdSide = 20;

        string expected = "The triangle is valid and is an EQUILATERAL";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }




    [Test]
    public void AnalyzeTriangle_Input20and20and10_OutputvalidIsoscelesTriangle()
    {
        //Arrange
        int firstSide = 20;
        int secondSide = 20;
        int thirdSide = 10;

        string expected = "The triangle is valid and is an ISOSCELES";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void AnalyzeTriangle_Input40and20and40_OutputvalidIsoscelesTriangle()
    {
        //Arrange
        int firstSide = 40;
        int secondSide = 20;
        int thirdSide = 40;

        string expected = "The triangle is valid and is an ISOSCELES";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void AnalyzeTriangle_Input60and20and60_OutputvalidIsoscelesTriangle()
    {
        //Arrange
        int firstSide = 60;
        int secondSide = 20;
        int thirdSide = 60;

        string expected = "The triangle is valid and is an ISOSCELES";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }




    [Test]
    public void AnalyzeTriangle_Input30and40and60_OutputvalidIScaleneTriangle()
    {
        //Arrange
        int firstSide = 30;
        int secondSide = 40;
        int thirdSide = 60;

        string expected = "The triangle is valid and is a SCALENE";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void AnalyzeTriangle_Input90and40and100_OutputvalidIScaleneTriangle()
    {
        //Arrange
        int firstSide = 90;
        int secondSide = 40;
        int thirdSide = 100;

        string expected = "The triangle is valid and is a SCALENE";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void AnalyzeTriangle_Input80and60and30_OutputvalidIScaleneTriangle()
    {
        //Arrange
        int firstSide = 80;
        int secondSide = 60;
        int thirdSide = 30;

        string expected = "The triangle is valid and is a SCALENE";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void AnalyzeTriangle_Input10and20and15_OutputvalidIScaleneTriangle()
    {
        //Arrange
        int firstSide = 10;
        int secondSide = 20;
        int thirdSide = 15;

        string expected = "The triangle is valid and is a SCALENE";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void AnalyzeTriangle_Input25and20and35_OutputvalidIScaleneTriangle()
    {
        //Arrange
        int firstSide = 25;
        int secondSide = 20;
        int thirdSide = 35;

        string expected = "The triangle is valid and is a SCALENE";
        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        //Assert
        Assert.AreEqual(expected, actual);
    }
}
