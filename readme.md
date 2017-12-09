# DNX.Helpers.Log4Net

![DNX Solutions Logo](http://dnx-solutions.co.uk/favicon-32x32.png)
[DNX.Helpers.Log4Net](http://github.com/martinsmith1968/DNX.Helpers.Log4Net) is a .NET package that contains the bits that make working with Log4Net that little bit more pleasant.

It is designed to make your code should as readable as possible at the highest level possible.

E.g. Replaces the repetitive code below (which has the potential to become out of step):

```csharp
if (logger.IsDebugEnabled)
{
    logger.Debug(string.Format("The value is {0}", x));
}
```

with

```csharp
logger.DebugFunc(() => string.Format("The value is {0}", x));
```

Which will only evaluate the Func and output the result, if Debug is enabled

### Installation

From NuGet package explorer:

`Install-Package DNX.Helpers.Log4Net`

### Contents

Helpers are divided into the following namespaces:

| Namespace | Descripion |
| --- | --- |
| [main](Docs/Log4Net.md) | Classes to help with working with Log4Net |

Also, check out the [Unit Test](Test.DNX.Helpers.Log4Net) project for some usage examples.

### Reference

[Full Namespace reference](Reference/reference.md)

### To Do

[To Do](todo.md)

### Contributing

Contributions welcome. All code must be comprehensively covered by unit tests using [NUnit 3](http://www.nunit.org)

### Credits

By Martin Smith, 2001 onwards

### Licence

[Licence](licence.txt)

### Related Projects

| Project | Location |
| --- | --- |
| [DNX.Helpers](http://github.com/martinsmith1968/DNX.Helpers) | General purpose .NET standard library helpers |
| [DNX.Helpers.Console](http://github.com/martinsmith1968/DNX.Helpers.Console) | For working with console applications |
| [DNX.Helpers.CommandLine](http://github.com/martinsmith1968/DNX.Helpers.CommandLine) | For working with Command Line parsing |
| [DNX.Helpers.Log4Net](http://github.com/martinsmith1968/DNX.Helpers.Log4Net) | For working with Log4Net |
