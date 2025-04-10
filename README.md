# ArrayList Class Project in C#

## Overview

This project demonstrates the usage of the `ArrayList` class in C#. It shows how to store and retrieve mixed data types using an `ArrayList`, how boxing and unboxing work, and how to safely check types before casting.

## Features

- Create and populate an `ArrayList` with different data types:
  - `int`
  - `string`
  - `double`
  - `bool`
  - `DateTime`
  - `decimal`
- Display each element along with its index and data type.
- Demonstrate unboxing with type checking.
- Handle potential invalid casts gracefully using exception handling.

## Code Highlights

- Use of `is` keyword and `as` operator for type checking.
- Example of boxing (automatic conversion to `object`) and unboxing (manual cast back to the original type).
- Safe casting to avoid runtime errors like `InvalidCastException`.

## How to Run

1. Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Open the project in Visual Studio or any C# IDE, or compile via terminal:
   ```bash
   csc Program.cs
   ```
3. Run the executable:
   ```bash
   Program.exe
   ```

## Output Example

```
ArrayList contains the following values:
Index 0: 42 (System.Int32)
Index 1: Hello World (System.String)
Index 2: 3.14159 (System.Double)
Index 3: True (System.Boolean)
Index 4: 4/10/2025 10:33:00 AM (System.DateTime)
Index 5: 100 (System.Decimal)

Retrieving and unboxing values:
Unboxed int: 42
Unboxed string: Hello World
Unboxed double: 3.14159
Unboxed bool: True
Index 4 is not an int, it's a System.DateTime
Unboxed decimal: 100
```

---
## Notes

- While `ArrayList` is useful for mixed-type collections, using `List<T>` with generics is recommended in modern C# for type safety and performance.
- This project is intended for educational purposes to demonstrate legacy collection usage and type handling.

---

Let me know if you'd like a version with markdown formatting or a downloadable `.md` file!
