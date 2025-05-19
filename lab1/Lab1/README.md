# Zoo Management System

## Principles Used

- **SRP**: Клас `Lion` відповідає лише за поведінку левів. [Див. Lion.cs, рядки 10-29](https://github.com/VladyslavPerehuda/KPZ/blob/lab-1/Lab1/Lab1/Animals/Lion.cs#L10-L29).
- **OCP**: Інтерфейс `IAnimal` дозволяє додавати нових тварин. [Див. IAnimal.cs, рядки 10-16](https://github.com/VladyslavPerehuda/KPZ/blob/lab-1/Lab1/Lab1/Animals/IAnimal.cs#L10-L16).
- **LSP**: Метод `AddAnimal` приймає `IAnimal`, тому будь-який його підтип (наприклад, `Lion`) може бути підставлений без жодної додаткової логіки. [Див. ZooInventory.cs, рядки 20-23](https://github.com/VladyslavPerehuda/KPZ/blob/lab-1/Lab1/Lab1/Management/ZooInventory.cs#L20-L23).
- **ISP**: `IAnimal` має лише необхідні методи. [Див. IAnimal.cs, рядки 12-15](https://github.com/VladyslavPerehuda/KPZ/blob/lab-1/Lab1/Lab1/Animals/IAnimal.cs#L12-L15).
- **DIP**: `Zoo` залежить від `IAnimal`. [[Див. ZooInventory.cs, рядки 15-23](https://github.com/VladyslavPerehuda/KPZ/blob/lab-1/Lab1/Lab1/Management/ZooInventory.cs#L15-L23)]
- **DRY**: Методи в `IAnimal` уникають дублювання. [Див. IAnimal.cs, рядки 10-16](https://github.com/VladyslavPerehuda/KPZ/blob/lab-1/Lab1/Lab1/Animals/IAnimal.cs#L10-L16).
- **Композиція над успадкуванням**: `ZooInventory` зберігає колекцію тварин як `List<IAnimal>`, а не є підкласом якоїсь конкретної тварини. [[ZooInventory.cs, рядки 15–18](https://github.com/VladyslavPerehuda/KPZ/blob/lab-1/Lab1/Lab1/Management/ZooInventory.cs#L15-L18)]