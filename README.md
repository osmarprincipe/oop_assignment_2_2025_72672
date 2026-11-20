# OOP Exam Questions (C#)

Object-Oriented Programming assignment 2, BSc in Computing, Dorset College Dublin (2025).

Four exam-style programming questions solved in C#, each with xUnit tests.

| Question | Topic |
|---|---|
| 1 | Regular expressions (Irish mobile number validation) and a discount lookup by membership level |
| 2 | Exception handling: safe division, number parsing and user registration with age validation |
| 3 | Collections: product ratings with average calculation and comparison |
| 4 | String formatting: zero-padded numbers and euro price formatting |

## Project structure

```
oop_assignment_2_2025_72672/   console app; Models/ExamQuestion_1..4.cs
ExamQuestions.Tests/           xUnit tests, one class per question
```

## Run

Requires the .NET 8 SDK.

```bash
dotnet run --project oop_assignment_2_2025_72672
dotnet test
```

## Tests

26 xUnit tests (facts and theories) cover valid and invalid input for every question, including edge cases such as division by zero and an empty ratings list.
