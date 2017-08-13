using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private const int AxeAttack = 1;
    private const int AxeDurability = 1;
    private const int DummyHealth = 20;
    private const int DummyXp = 20;

    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void TestInit()
    {
        // Arrange
        axe = new Axe(AxeAttack, AxeDurability);
        dummy = new Dummy(DummyHealth, DummyXp);
    }

    [Test]
    public void AxeLosesDurabilityAfterAttack()
    {
        // Act
        this.axe.Attack(dummy);

        // Assert
        Assert.AreEqual(0, axe.DurabilityPoints);
    }

    [Test]
    public void AttackWithBrokenAxe()
    {
        // Act
        this.axe.Attack(dummy);

        // Assert
        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.AreEqual("Axe is broken.", ex.Message);
    }
}