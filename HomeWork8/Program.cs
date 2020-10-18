using System;

namespace dz8
{
    #region
    // Создать класс студентов (обычные свойства Имя, Фамилия, Возраст и т.д.)
    // Создать программу выдачи кофе студентам, приславшим задание на почту.
    // Создать класс, который будет иметь два метода. 1-й отмечает, что студент отправил задание и добавляет
    // его в коллекцию на выдачу кофе. 2-й метод выдает кофе на основании коллекции (тут просто вывести на экран
    // какой студен получил кофе.
    // Для организации списка использовать классы Stack и Queue.
    // Обратить внимание в каком порядке студенты получат кофе при использовании этих классов.

    // Дополнительно: реализовать очередь (класс MyQueue) самостоятельно. В примерах есть реализация стека (MyStack.cs) можно
    // на нее опираться. Хранилище для свой очереди выбираете сами (или массив или связный список). ЛУЧШЕ СВЯЗНЫЙ СПИСОК
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            var stydCo = new StydCoffee();

            var styd1 = new Stydent("Karl", "Brown", 19);
            var styd2 = new Stydent("Max", "Laraborn", 18);
            var styd3 = new Stydent("Peter", "Risford", 19);
            var styd4 = new Stydent("Rick", "Hanzl", 20);
            var styd5 = new Stydent("Liz", "Taylor", 18);

            stydCo.takeCofee(styd1);
            stydCo.takeCofee(styd3);
            stydCo.takeCofee(styd4);
            stydCo.takeCofee(styd5);

            stydCo.showCoffee();
        }
    }
}
