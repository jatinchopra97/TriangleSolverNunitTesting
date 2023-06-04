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
}
