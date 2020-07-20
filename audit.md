# audit
## command line

- create a file -> `touch`
- create a directory -> `mkdir`
- display list of content of directory -> `ls`, flags= -a (list everything) or -all, -l or --long (w description)
- change directory -> `cd`
- remove file or directory -> `rm` flags = -r (recursive),-f (force)
- running priviliged commands or administrator -> `sudo`
- install new packages ->`apt install`
- read file content -> `cat`
- edit file content -> `nano`
- print current path -> `pwd`

## version control system

- `git add` ->  copy resources into virtual directory or local server
- `git commit` -> save resources to virtual_directory or local server.
- `git status` -> display changed resources in history
- `git init` -> initialize virtual directoryy
- `git config` -> configure name, email, or git options
- `git remote` -> edit or remove connection
- `git clone` -> copy resources from remote server to locl server
- `git push` -> copy resources from local server to remote server
- `git log` -> print history of virtual directory or local server

## secure shell

- `ssh-keygen` -> generate a private/piblic keypair, similar to username and password, flags = -t (a;gorithm type), -b (binary),
- `ssh-agent` -> run current directory in privileged state with ssh
- `ssh-add` -> add private key to prviliged state with ssh

## dotnet [.NET]

- .NET Standard = support both the .NET Framework (Windows only) and .NET Core (multi platform)
- .NET Core = supports languages, desktop apps, mobile apps, and web apps
- Languages = support for C#, F$, Visual Basic, VB.NET, c, C++, Python, JavaScript
- Desktop = support for winforms, UNP, XAML, WPF
0 Mobile = support of Xamarin (Windows, Android, iOS/ipadOS)

## csharp (CS)

- CIL, MSIL, IL = code will compile to intermediate language
- Assembly = compliled codebase into DLL, EXE, or SVC
- Language = object-based, strongly-typed, compiled, managed, general programming
- Datatypes = primatives, references, value
- Primative = int, float, double, decimal, string, char, bool (including unsigned)
- Reference = string, class, interface
- Value = all primitives except string, struct, enum
- CLR = .NET runtime, support BCL (base class lib), CTS (common type system), VES (virtual execution sys), JIT (just in time)
- Runtime = portability, interoperability, memory management
- Scopes = support for 4 lv's of scoping, namely namespace, data structure (class, interface, struct, enum), methods, block (control flow, exception handling)
- Collections = support for array (1-dimensonal array, multi-dimensional array), for list
- Exception Handling = handle with try/catch/finally, try with no catch, catch (not recommended), catch
- Unit Testing = support for running codebase logic w/o application start, structurally setup with arrange/act/assert block, test coverage
- Serialization = convert data from one system to another, transfer object to xml text format
- Debugging - support for running coebase in steps including breakpoints, conditions.
- Modifiers = support 2 types, access (public > protected > internal > private) and regular/extended (const, readonly, static, override)
- Method Overloading = support for methods in the same data structure, with same name but different signature
- Object Oriented Programming = support for Abstraction, Encapsulation, Inheritance, Polymorphism (known as the pillars)
--Overriding -> Within a class can overwrite a method with a different result (ex toString)
- overloading -> two version of same method with different parameters
--abstraction -> simplyfying the code in a function and letting the user know that the function is doing the job without knowing the detail.


## Need to review:
- Arrays
- For loops
- Encapsulation
