namespace DynamicDataBasics;

using NUnit.Framework;

[TestFixture]
public class Tests
{
    [TestCase]
    public void PassACanaryTest()
    {
        const int toTest = 2 + 2;
        Assert.That(toTest, Is.EqualTo(4));
    }
}