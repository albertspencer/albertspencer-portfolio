# ThoughtTronix Orders – C# OOP Review (Homework 1)

A small **C# console application** that models products and customer orders for the fictional company **ThoughtTronix**.
It demonstrates **classes**, **object composition** (an `Order` has a list of `Product`), simple **aggregation**, and a computed **order total**.

## ✨ Features
- `Product` class with `Name`, `Description`, and `Price`
- `Order` class with `OrderId`, `CustomerName`, and `List<Product>`
- Calculates order totals by summing product prices
- Clean `ToString()` overrides for readable console output

## 🧰 Tech Stack
- C# (.NET)
- Console application
- OOP (classes, properties, lists)

## 🗂️ Project Structure
```text
homework-1-albertspencer/
├─ Models/
│  ├─ Product.cs
│  └─ Order.cs
├─ Program.cs
└─ homework-1-albertspencer.csproj
```

## ▶️ How to Run
```bash
# from this folder
dotnet build
dotnet run
```

## 📌 Example Output (sample)
```
Order #1001 - Alice Johnson
- Seraphine — $199.99
- Aegis Shield — $89.50
- ...
Total: $289.49
```

## 🧩 Notes
- This project was built as a **C# review** focused on class design and lists.
- Perfect as a starter portfolio piece for OOP fundamentals.
