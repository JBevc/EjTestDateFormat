namespace TestDateFormat.Tests;
using NUnit.Framework;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestValidDate()
    {
        string  dateCorrect = "02/09/2023";
        string result = DateFormatter.ChangeFormat(dateCorrect);

        Assert.AreEqual("2023-09-02", result);
    }

    [Test]
    public void TestInvalidFormat()
    {
        string dateIncorrect = "2023/28/03";
        string result = DateFormatter.ChangeFormat(dateIncorrect);

        Assert.AreEqual("2023-28-03",result);
    }

    [Test]
    public void TestEmptyDate()
    {
        string emptyDate = "";
        string result = DateFormatter.ChangeFormat(emptyDate);

        Assert.AreEqual("--",result);
    }
}