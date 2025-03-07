
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;


namespace TemplateEngine.Tests;

[TestFixture]
public class TemplateEngineTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("John")]
    public void GivenOneVariable_Evaluate_TemplateEngine(string name)
    {
        //Arrange
        TemplateEngine templateEngine   = new TemplateEngine();
        templateEngine.SetName(name);

        //Act
        var result = templateEngine.Evaluate();


        //Assert
        Assert.That("Hello John", Is.EqualTo(result));
    }

    [TestCase("John","Siemens")]
    public void GivenTwoVariables_Evaluate_TemplateEngine(string name, string company)
    {
        //Arrange
        TemplateEngine templateEngine = new TemplateEngine();
        templateEngine.SetName(name);
        templateEngine.SetCompany(company);

        //Act
        var result = templateEngine.Evaluate();


        //Assert
        Assert.That("Hello John Siemens", Is.EqualTo(result));
    }
}
