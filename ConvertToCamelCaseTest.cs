using NUnit.Framework;


public class Tests
{
    [Test]
    public void ConvertsDashSeperatedToCamelCase()
    {
        string s1 = "hello-there-you";
        Assert.AreEqual("helloThereYou", Converter.ToCamelCase(s1));
    }
}
