# C_Sharp_Tutorial

This repository contains C# code for learning the nuances of the language. It demonstrates its syntax for:

* Basic I/O

* Variables

* Arrays and 2D Arrays

* Functions

* Static variables and functions

* Class variables and functions

* Getter and setter methods

* If/else statements

* While and For loops

* Switch statements

* Exception handling

* Inheritance

## Highlights 

* Has namespace functionality

* Inheritance looks like it matches C++. Has override and virtual functions. Eg `class ItalianChef : Chef`, `public virtual void MakeSpecialDish()`, `public override void MakeSpecialDish()`

* 2D arrays look like `int[,]`

* Reference equality (both operands are the same underlying object): `System.Object.ReferenceEquals(a, b);`. Value equality: `a == b`.

* Print with `Console.WriteLine()` and read in with `Console.ReadLine()`

* Getter and setter methods: `public string Rating { get; set; }` or `public string Rating { get { return rating; } set { if value == "R" { rating = "R"; } else { rating = "NR"; } }`

I learned about the C# syntax through https://www.youtube.com/watch?v=GhQdlIFylQ8&t=632s. Thank you for the helpful learning tips.
