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
}
