# DNX.Helpers.Log4Net

## ILogExtensions

| Method | Parameters | Description |
| --- | --- | --- |
| ILog.DebugFunc | Func\<string\> | Writes a Debug message, if Debug is enabled |
| ILog.DebugFunc | Func\<string\>, Func\<Exception\> | Writes a Debug message with Exception, if Debug is enabled 
| ILog.InfoFunc | Func\<string\> | Writes a Info message, if Info is enabled |
| ILog.InfoFunc | Func\<string\>, Func\<Exception\> | Writes a Info message with Exception, if Info is enabled
| ILog.WarnFunc | Func\<string\> | Writes a Warn message, if Warn is enabled |
| ILog.WarnFunc | Func\<string\>, Func\<Exception\> | Writes a Warn message with Exception, if Warn is enabled |
| ILog.ErrorFunc | Func\<string\> | Writes a Error message, if Error is enabled |
| ILog.ErrorFunc | Func\<string\>, Func\<Exception\> | Writes a Error message with Exception, if Error is enabled |
| ILog.FatalFunc | Func\<string\> | Writes a Fatal message, if Fatal is enabled |
| ILog.FatalFunc | Func\<string\>, Func\<Exception\> | Writes a Fatal message with Exception, if Fatal is enabled |

## LogManagerHelper

| Method | Parameters | Description |
| --- | --- | --- |
| GetDefaultLogger | | Returns the default `ILog` logger |
| GetLoggerFor | object | Returns a logger appropriate for the type of specified instance `object` |
| GetMyLogger | | Returns a logger appropriate for the class calling this method |
| GetLoggerFor\<T\> | | Returns a logger appropriate for the type `T` |
