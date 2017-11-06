
# DNX.Helpers.Log4Net


## LogExtensions

Class LogExtensions for Debug

Class LogExtensions for Error

Class LogExtensions for Fatal

Class LogExtensions for Info

Class LogExtensions for Warn


### M:DNX.Helpers.Log4Net.DebugFunc(logger, messageText)

Writes a Debug message, if Debug is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The messageText. |

### M:DNX.Helpers.Log4Net.DebugFunc(logger, messageText, exception)

Writes a Debug message with Exception, if Debug is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The message text. |
| exception | *System.Func{System.Exception}*<br>The exception. |

### M:DNX.Helpers.Log4Net.ErrorFunc(logger, messageText)

Writes a Error message, if Error is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The messageText. |

### M:DNX.Helpers.Log4Net.ErrorFunc(logger, messageText, exception)

Writes a Error message with Exception, if Error is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The message text. |
| exception | *System.Func{System.Exception}*<br>The exception. |

### M:DNX.Helpers.Log4Net.FatalFunc(logger, messageText)

Writes a Fatal message, if Fatal is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The messageText. |

### M:DNX.Helpers.Log4Net.FatalFunc(logger, messageText, exception)

Writes a Fatal message with Exception, if Fatal is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The message text. |
| exception | *System.Func{System.Exception}*<br>The exception. |

### M:DNX.Helpers.Log4Net.InfoFunc(logger, messageText)

Writes a Info message, if Info is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The messageText. |

### M:DNX.Helpers.Log4Net.InfoFunc(logger, messageText, exception)

Writes a Info message with Exception, if Info is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The message text. |
| exception | *System.Func{System.Exception}*<br>The exception. |

### M:DNX.Helpers.Log4Net.WarnFunc(logger, messageText)

Writes a Warn message, if Warn is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The messageText. |

### M:DNX.Helpers.Log4Net.WarnFunc(logger, messageText, exception)

Writes a Warn message with Exception, if Warn is enabled

| Name | Description |
| ---- | ----------- |
| logger | *log4net.ILog*<br>The logger. |
| messageText | *System.Func{System.String}*<br>The message text. |
| exception | *System.Func{System.Exception}*<br>The exception. |

## LogManagerExtensions

Class LogManagerExtensions.


### M:DNX.Helpers.Log4Net.GetDefaultLogger

Gets the default logger.


#### Returns

ILog.


### M:DNX.Helpers.Log4Net.GetLogger``1

Gets a logger for the type


#### Returns

ILog.


### M:DNX.Helpers.Log4Net.GetLoggerFor(parent)

Gets the logger for an object

| Name | Description |
| ---- | ----------- |
| parent | *System.Object*<br>The parent. |


#### Returns

ILog.


### M:DNX.Helpers.Log4Net.GetMyLogger

Gets the logger for where it's currently running (owner)


#### Returns

ILog.


