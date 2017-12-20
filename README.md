
# Advent of Code 2017
```
.-----------------------------------------------.       
|                                               |  25
|                                               |  24
|                                               |  23
|                                               |  22
|                                             * |  21
|                                         *───┤ |  20 **
|                             *───────oTo─┘┌o┌┘ |  19 **
|                             └┐┌───┐┌─*o──┴─┼o |  18 **
|                           ┌──┘└──┐└┴o└────*│V |  17 **
|  *─────────────────|(────┐└─────┬┴┴┴┴┬────┘└┘ |  16 **
|  └────────∧∧∧────────*o──┴──────┤    ├──────┐ |  15 **
|          ┌───┬───────┘┌────*o───┤    ├──────┘ |  14 **
| ┌──┤|├───┘o──┘┌───────┘o┬┴┴┴┴┬──┤SRAM├───*──o |  13 **
| ├───────∧∧∧───┘o┬───────┤    ├*─┴┬┬┬┬┴──┐└──┐ |  12 **
| └──────┐┌─────┬┴┴┴┴┬────┤HALF├┘┌─*o─────┴───┘ |  11 **
| ┌─┬o┌──┘├─────┤    ├────┤ADDR├─┘V└─────────*┐ |  10 **
| └o└┐│o──┴─────┤   A├o┌──┴┬┬┬┬┴──┘*─────────┘│ |   9 **
| ┌──┘└──────┬──┤   L├─┘*──oTo────┐└─────┐o───┤ |   8 **
| └┐┌────────┘*─┤   U├──┘┌───o┌───┘┌────┐└───┐│ |   7 **
| ┌┘│V*─∧∧∧───┘o┴┬┬┬┬┴───┴────┴────┘o─┐┌┘┌───┘= |   6 **
| └─┴┘└─┬───────────────────∧∧∧──────┐└┴─┘┌───* |   5 **
| *────┐└─────────[─]─o┌────────────┐└────┴o┌─┤ |   4 **
| └───┐└───[─]──┬──────┘┌─────*o────┴───────┘o┘ |   3 **
| ┌───┘┌──┐o────┘┌──────┴────o└───────────────* |   2 **
| └────┴─o└──┤[]├┴─────o*────────────┤[]├─────┘ |   1 **
'-----------------------------------------------'       

```
C# solutions to http://adventofcode.com/2017 using .NET Core 2.0.

## Dependencies

- This library is based on `.NET Core 2.0`. It should work on Windows, Linux and OS X.
- `HtmlAgilityPack.NetCore` is used for problem download.

## Running

To run the project:

1. Install .NET Core.
2. Download the code.
3. Run `dotnet run <day>`.

To prepare for the next day:

1. Run `dotnet run update <day>`.