using DynamicData.Kernel;

namespace DynamicDataBasics;

using DynamicData;
using NUnit.Framework;

[TestFixture]
public class StorageListShould
{
    [TestCase]
    public void PassACanaryTest()
    {
        const int toTest = 2 + 2;
        Assert.That(toTest, Is.EqualTo(4));
    }

    [TestCase]
    public void AddIntAddsAnIntegerToTheList()
    {
        var sut = new SourceList<Int32>();
        sut.Add(79);

        var expected = new[]
        {
            79,
        };
        Assert.That(sut.Items, Is.EqualTo(expected));
    }

    [TestCase]
    public void AddManyIntsAddsManyIntegerToTheList()
    {
        var sut = new SourceList<Int32>();
        var expected = new[] { 58, 34, 6, };
        sut.AddRange(expected);

        Assert.That(sut.Items, Is.EqualTo(expected));
    }

    [TestCase]
    public void RemoveIntRemovesIntegerFromTheList()
    {
        var sut = new SourceList<Int32>();
        var original = new[] { 55, 96, 86, };
        sut.AddRange(original);

        sut.Remove(86);

        var expected = original.AsList();
        expected.Remove(86);
        Assert.That(sut.Items, Is.EqualTo(expected));
    }
}