using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using static TechniquesDeTest.Echantillon;

namespace TechniquesDeTest.Tests.Unit;

public class EchantillonTests
{
    public readonly Echantillon _sut = new();

    [Fact]
    public void StringAssertionExample()
    {
        var fullName = _sut.FullName;

        fullName.Should().Be("Sylvanas Coursevent");
        fullName.Should().NotBeEmpty();
        fullName.Should().NotBeNullOrEmpty();
        fullName.Should().StartWith("Sylvanas");
        fullName.Should().EndWith("Coursevent");
    }

    [Fact]
    public void NumberAssertionExample()
    {
        var age = _sut.Age;

        age.Should().Be(30);
        age.Should().BePositive();
        age.Should().BeGreaterThan(18);
        age.Should().BeLessThanOrEqualTo(30);
        age.Should().BeInRange(18, 60);
    }

    [Fact]
    public void DateAssertionExample()
    {
        var dateOfBirth = _sut.DateOfBirth;

        dateOfBirth.Should().Be(new(1993, 1, 1));
        dateOfBirth.Should().HaveYear(1993);
        dateOfBirth.Should().HaveDay(1);
        dateOfBirth.Should().HaveMonth(1);
    }

    [Fact]
    public void ObjectAssertionExample()
    {
        var expected = new User()
        {
            FullName = "Sylvanas Coursevent",
            Age = 30,
            DateOfBirth = new(1993, 1, 1)
        };

        _sut.AppUser.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ListAssertionExample()
    {
        var expected = new User()
        {
            FullName = "Sylvanas Coursevent",
            Age = 30,
            DateOfBirth = new(1993, 1, 1)
        };

        _sut.Users.Should().ContainEquivalentOf(expected);
        _sut.Users.Should().HaveCount(3);
        _sut.Users.Should().Contain(x => x.FullName.StartsWith("Sylvanas") && x.Age > 21);
    }

    [Fact]
    public void ListIntAssertionExample()
    {
        _sut.Numbers.Should().Contain(5);
    }

    [Fact]
    public void ExceptionAssertionExample()
    {
        Action act = () => _sut.Register(15);

        act.Should().Throw<AgeMustBeGreaterThan18>().WithMessage("L'age doit être supérieur à 18 ans.");
    }

    [Fact]
    public void EventAssertionExample()
    {
        var monitorSubject = _sut.Monitor();
        _sut.RaiseExampleEvent();
        monitorSubject.Should().Raise("ExampleEvent");
    }
}



