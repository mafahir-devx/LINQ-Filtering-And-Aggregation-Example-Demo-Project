[project_readme.md](https://github.com/user-attachments/files/32321391/project_readme.md)
# LINQ Filtering & Aggregation Example

A lightweight C# console application demonstrating basic list operations, filtering, and data aggregation using **LINQ (Language Integrated Query)**.

## 📌 Project Overview

This project showcases how to manipulate object collections in C# using strongly typed models and expressive LINQ extension methods (`Where` and `Average`).

The application accomplishes the following tasks:
1. **Data Initialization**: Instantiates an in-memory list of `Person` objects.
2. **Filtering**: Filters the collection to extract individuals who are adults (age $\ge 18$).
3. **Aggregation**: Calculates the mean age across the entire dataset.
4. **Console Output**: Displays formatted results cleanly to the terminal.

---

## 🛠️ Tech Stack & Requirements

- **Language:** C#
- **Framework:** .NET Core / .NET 6+ (or .NET Framework 4.5+)
- **IDE/Tools:** Visual Studio, Visual Studio Code, or Rider

---

## 🚀 Getting Started

### Prerequisites

Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine. You can verify your installation by running:

```bash
dotnet --version
```

### Running the Application

1. **Clone or save the project file:**
   Ensure you have a C# console project set up.

2. **Replace or insert the code in `Program.cs`.**

3. **Build and run the project:**

   ```bash
   dotnet run
   ```

---

## 💻 Code Structure

- **`Person` Class**: An immutable record-like class representing an individual with `Name` and `Age` properties.
- **`Program.Main()`**: The application entry point performing collection initialization, LINQ queries, and console output formatting.

```csharp
var adults = people.Where(person => person.Age >= 18).ToList();
var averageAge = people.Average(person => person.Age);
```

---

## 📄 Expected Output

When executed, the program outputs:

```text
Adults:
- Ava (24)
- Mia (31)
Average age: 24.0
```

---

## 📜 License

This project is open-source and available under the [MIT License](LICENSE).
