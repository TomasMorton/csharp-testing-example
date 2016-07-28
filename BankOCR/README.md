# BankOCR kata

This project is a placeholder for practicing the Bank OCR kata.

## Getting started

You'll want to install the SpecFlow extension for Visual Studio 2015:

<img width="709" alt="screen shot 2016-07-28 at 3 46 22 pm" src="https://cloud.githubusercontent.com/assets/4039018/17228800/54dcd988-54da-11e6-98ca-137650891782.png">

The project is preconfigured to execute Cucumber (SpecFlow) tests with xUnit You can run
the tests in Visual Studio with `ReSharper -> Unit Tests -> Run Unit Tests` or with `Test -> Run -> All Tests`.

## Writing features

Feature files are stored in [BankOCR.Test](BankOCR.Test),
and you can add additional tests by adding additional `Scenario:` constructs to
the existing feature file or by adding additional feature files with `Add -> New Item -> SpecFlow Feature File`

## Implementing step definitions

When you run the tests, SpecFlow will output method stubs of step definitions
to implement the tests like this:

```
[When(@"^I parse the file$")]
public void I_Parse_The_File() {
    // Write code here that turns the phrase above into concrete actions
    throw new PendingStepException();
}
```

Step definitions can be defined with the `Given`, `When`, and `Then` method
attributes in any class you like, though the `BankOCR.Test/BankOCRSteps.cs`
class has already been defined for you to start from.

## Resources

For more information, see:

* [Our wiki page on the kata](https://github.com/testdouble/contributing-tests/wiki/Bank-OCR-Kata-in-Cucumber)
* [The kata's home page](http://www.codingdojo.org/cgi-bin/index.pl?KataBankOCR)