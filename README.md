# Uninitialized Property Access in C#

This repository demonstrates a subtle but potentially problematic error in C#: accessing a property of a class before it has been explicitly assigned a value.  While not always resulting in a compiler error, it can lead to unexpected behavior, particularly in multithreaded or complex applications.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file provides a corrected version.

**Key takeaway:** Always ensure class properties have a defined value before use, either through initialization in the constructor or explicit assignment before access.