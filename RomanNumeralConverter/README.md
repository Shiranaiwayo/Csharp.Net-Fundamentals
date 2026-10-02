# 🔢 C# Roman Numeral Converter

A simple console-based application built while learning arrays, loops, input handling, and algorithmic thinking in C#. The application takes a number as input and converts it into its corresponding Roman numeral representation.

## 🚀 Key Logic & Features

* **Number Input:** Prompts the user to enter a number that should be converted into Roman numerals.
* **Value Arrays:** Uses two arrays to store Roman numeral values and their corresponding symbols.
* **Conversion Logic:** Loops through the values from largest to smallest and subtracts each value from the input while adding the corresponding Roman numeral.
* **Greedy Algorithm:** Uses the largest possible Roman numeral value at each step to build the final result.
* **Looping:** Uses a `for` loop to iterate through all available Roman numeral values and a `while` loop to handle repeated symbols such as `III` or `XXX`.
* **Roman Numeral Rules:** Includes special combinations such as `IV`, `IX`, `XL`, `XC`, `CD`, and `CM`.
* **Console Output:** Displays the resulting Roman numeral after the conversion is complete.

## 🛠️ Built With

* **Language:** C#
* **Framework:** .NET (Console Application)
* **IDE:** Visual Studio Community
