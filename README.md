# GeometryLibrary

## Описание
`GeometryLibrary` - это библиотека на C#, предназначенная для работы с геометрическими фигурами. Она предоставляет функциональность для создания и вычисления площади кругов и треугольников. Библиотека использует паттерн "Абстрактная фабрика" для создания фигур, что позволяет клиентскому коду оставаться независимым от конкретных классов фигур.

## Функции
- Создание кругов и треугольников через фабрики `CircleFactory` и `TriangleFactory`.
- Вычисление площади фигур с помощью метода `CalculateArea`.

## Пример использования
```csharp
var circleFactory = new CircleFactory();
var circle = circleFactory.CreateShape(5); // радиус 5
Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

var triangleFactory = new TriangleFactory();
var triangle = triangleFactory.CreateShape(3, 4, 5); // стороны 3, 4, 5
Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
```

## Тестирование
Библиотека включает набор модульных тестов, написанных с использованием NUnit, для проверки корректности вычислений площадей фигур.
