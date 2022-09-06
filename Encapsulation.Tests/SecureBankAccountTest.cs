namespace Encapsulation.Tests;

public class SecureBankAccountTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Instantiate_New_Account_Should_Get_0_Account_Balance()
    {
        //arrange
        var secureBankAccount = new SecureBankAccount("_newAccountNumberForTest");
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        //act
        secureBankAccount.DisplayAccountBalanceDetails();

        //assert
        var output = stringWriter.ToString();
        Assert.That(output,Is.EqualTo($"Your account balance is 0\n"));
    }

    [Test]
    public void Debit_From_Account_Balance_Able_To_Have_Negative_Balance()
    {
        //arrange
        var secureBankAccount = new SecureBankAccount("_newAccountNumberForTest");
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        //act
        secureBankAccount.DebitAmount(100);
        secureBankAccount.DisplayAccountBalanceDetails();

        //assert
        var output = stringWriter.ToString();
        Assert.That(output, Is.EqualTo($"Your account balance is -100\n"));
    }
}