# c#_practess_one_#
wellcome-----c#


## Welcome to C# Programming

Welcome to my C# Programming Practice Repository!

This repository contains my learning journey in **C# Programming using Visual Studio 2022**. It includes important concepts, definitions, explanations, practical examples, exercises, and screenshots from my weekly lessons and assignments.

The main purpose of this repository is to develop my programming knowledge, improve my problem-solving skills, and understand how to create applications using C#.

---

## About C#

C# (C-Sharp) is a modern, object-oriented, and general-purpose programming language developed by Microsoft.

It is commonly used to develop:

- Windows Desktop Applications
- Web Applications
- Mobile Applications
- Games
- Database Applications
- Enterprise Software

C# runs on the .NET platform, which provides libraries and tools for developing different types of applications.

---

## Learning Objectives

Through this course, I aim to:

1. Understand the fundamentals of C# programming.
2. Learn variables and data types.
3. Understand operators and expressions.
4. Apply decision-making statements.
5. Use loops and repetition structures.
6. Learn how to work with files.
7. Understand exception handling.
8. Develop practical applications using Windows Forms.
9. Improve logical thinking and problem-solving skills.

---

# CHAPTER 1: INTRODUCTION TO VISUAL C#

### 1.1 Introduction

Visual C# is a programming environment used to create applications using the C# language.

Visual Studio is an Integrated Development Environment (IDE) that provides tools for writing, debugging, and running programs.

### 1.2 Basic C# Program

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to C# Programming!");
    }
}
```

### 1.3 Important Concepts

- **Class:** A blueprint used to create objects.
- **Main Method:** The entry point of a traditional C# console application.
- **Namespace:** Organizes classes and other types.
- **Statement:** An instruction executed by a program.
- **Comment:** Text used to explain code.
- **IDE:** Software used to develop applications.

### 1.4 Comments

```csharp
// Single-line comment

/*
Multi-line comment
*/
```

### 1.5 Output Statements

```csharp
Console.WriteLine("Hello World");
Console.Write("Welcome");
```

### 1.6 Input Statements

```csharp
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine(name);
```

---

# CHAPTER 2: DATA PROCESSING

### 2.1 Introduction

Data Processing refers to collecting, storing, converting, and manipulating data in a computer program.

### 2.2 Variables

A variable is a named memory location used to store data.

```csharp
int age = 20;
string name = "Ahmed";
double price = 25.50;
```

### 2.3 Data Types

| Data Type | Description |
|---|---|
| int | Stores whole numbers |
| double | Stores decimal numbers |
| float | Stores decimal numbers |
| decimal | Stores precise decimal values |
| string | Stores text |
| char | Stores one character |
| bool | Stores true or false |

### 2.4 Constants

A constant is a value that cannot be changed after declaration.

```csharp
const double PI = 3.14159;
```

### 2.5 Operators

**Arithmetic Operators**

- `+` Addition
- `-` Subtraction
- `*` Multiplication
- `/` Division
- `%` Modulus

**Comparison Operators**

- `==` Equal to
- `!=` Not equal to
- `>` Greater than
- `<` Less than
- `>=` Greater than or equal to
- `<=` Less than or equal to

**Logical Operators**

- `&&` AND
- `||` OR
- `!` NOT

### 2.6 Type Conversion

Type conversion changes data from one type to another.

```csharp
string number = "100";
int result = Convert.ToInt32(number);
```

Using Parse:

```csharp
int age = int.Parse("25");
```

Using TryParse:

```csharp
int number;

if (int.TryParse("50", out number))
{
    Console.WriteLine(number);
}
```

### 2.7 Exception Handling

Exception handling is used to manage runtime errors and prevent unexpected program termination.

**Try-Catch Example**

```csharp
try
{
    int number = Convert.ToInt32("ABC");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

Important keywords:

- `try`: Contains code that may cause an exception.
- `catch`: Handles an exception.
- `finally`: Executes whether an exception occurs or not.
- `throw`: Used to throw an exception.

---

# CHAPTER 3: MAKING DECISIONS

### 3.1 Introduction

Decision-making statements allow a program to execute different instructions depending on whether a condition is true or false.

### 3.2 If Statement

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("Adult");
}
```

### 3.3 If-Else Statement

```csharp
int mark = 75;

if (mark >= 50)
{
    Console.WriteLine("Pass");
}
else
{
    Console.WriteLine("Fail");
}
```

### 3.4 If-Else-If Statement

```csharp
int mark = 85;

if (mark >= 90)
{
    Console.WriteLine("Grade A");
}
else if (mark >= 80)
{
    Console.WriteLine("Grade B");
}
else if (mark >= 50)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Fail");
}
```

### 3.5 Nested If Statement

A nested if is an if statement inside another if statement.

```csharp
int age = 20;
bool registered = true;

if (age >= 18)
{
    if (registered)
    {
        Console.WriteLine("Access Granted");
    }
}
```

### 3.6 Switch Statement

A switch statement selects one option from multiple possible cases.

```csharp
int day = 2;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    default:
        Console.WriteLine("Invalid Day");
        break;
}
```

### 3.7 Conditional Operator

```csharp
int age = 20;

string result = age >= 18 ? "Adult" : "Minor";
```

---

# CHAPTER 4: LOOPS, FILES, AND RANDOM NUMBERS

### 4.1 Introduction

This chapter explains repetition structures, file handling, and random number generation.

### 4.2 For Loop

A for loop repeats a block of code a specific number of times.

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

### 4.3 While Loop

A while loop repeats while a condition remains true.

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

### 4.4 Do-While Loop

A do-while loop executes its code at least once before checking the condition.

```csharp
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 5);
```

### 4.5 Nested Loops

A nested loop is a loop inside another loop.

```csharp
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine(i + " " + j);
    }
}
```

### 4.6 Break and Continue

**Break:** Terminates the loop.

**Continue:** Skips the current iteration and moves to the next iteration.

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
        continue;

    Console.WriteLine(i);
}
```

### 4.7 File Handling

File handling allows a program to create, read, write, and manage files.

Important classes:

- File
- FileInfo
- StreamReader
- StreamWriter

**Writing to a File**

```csharp
using System.IO;

File.WriteAllText("students.txt", "Welcome to C#");
```

**Reading from a File**

```csharp
string content = File.ReadAllText("students.txt");

Console.WriteLine(content);
```

**StreamWriter**

```csharp
using (StreamWriter writer = new StreamWriter("data.txt"))
{
    writer.WriteLine("Hello Students");
}
```

**StreamReader**

```csharp
using (StreamReader reader = new StreamReader("data.txt"))
{
    string content = reader.ReadToEnd();

    Console.WriteLine(content);
}
```

### 4.8 Random Numbers

Random numbers are generated using the Random class.

```csharp
Random random = new Random();

int number = random.Next(1, 101);

Console.WriteLine(number);
```

---

# PRACTICAL SKILLS

During this course, I practice developing applications using:

- Windows Forms
- Labels and Buttons
- TextBoxes
- RadioButtons
- ListBoxes
- MessageBox
- Try-Catch
- OpenFileDialog
- SaveFileDialog
- File Reading and Writing
- Input Validation

---

# REPOSITORY STRUCTURE

```text
C-sharp-practess-one/
│
├── Week1/
│   ├── Screenshots/
│   └── README.md
│
├── Week2/
│   ├── Screenshots/
│   └── README.md
│
├── Week3/
│   ├── Screenshots/
│   └── README.md
│
├── Week4/
│   ├── Screenshots/
│   └── README.md
│
├── Week5/
│   ├── Screenshots/
│   └── README.md
│
├── Week6/
│   ├── Screenshots/
│   └── README.md
│
├── Week7/
│   ├── Screenshots/
│   └── README.md
│
├── Week8/
│   ├── Screenshots/
│   └── README.md
│
├── Week9/
│   ├── Screenshots/
│   └── README.md
│
└── README.md
```

---

# CONCLUSION

C# programming has helped me understand the fundamentals of software development, logical thinking, data processing, decision-making, loops, and file handling.

I will continue improving my programming skills through practical exercises, assignments, and real-world projects.

**Thank you for visiting my C# Practice Repository!**

**Language:** C#  
**IDE:** Visual Studio 2022  
**Platform:** .NET  
**Student:** C# Programming Student
