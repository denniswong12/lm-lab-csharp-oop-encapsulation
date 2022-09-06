namespace Encapsulation.Tests;

public class DodgyBankAccountTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Instantiate_New_Account_Should_Get_0_Account_Balance()
    {
        //arrange
        var dodgyBankAccount = new DodgyBankAccount("_newAccountNumberForTest");
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        //act
        dodgyBankAccount.GetAccountBalanceDetails();

        //assert
        var output = stringWriter.ToString();
        Assert.That(output,Is.EqualTo($"Your account balance is 0\n"));
    }

    [Test]
    public void Change_Account_Balance_From_Other_Class_Able_To_Change_It()
    {
        //arrange
        var dodgyBankAccount = new DodgyBankAccount("_newAccountNumberForTest");
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        //act
        dodgyBankAccount.AccountBalance = 9000;
        dodgyBankAccount.GetAccountBalanceDetails();

        //assert
        var output = stringWriter.ToString();
        Assert.That(output, Is.EqualTo($"Your account balance is 9000\n"));
    }
}