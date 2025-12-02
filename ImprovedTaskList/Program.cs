namespace ImprovedTaskList
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("║ Улучшенный Таск-Менеджер" +
                              "\n║ 1. Добавить задачу" +
                              "\n║ 2. Посмотреть задачи" +
                              "\n║ 3. Отметить задачу как выполненную" +
                              "\n║ 4. Выйти");
            List<Task> tasks = new List<Task>();
            while (true)
            {
                Console.WriteLine("Введите нужное действие");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("-- Введите задачу");
                        string newTask = Console.ReadLine();
                        tasks.Add(new Task(newTask));
                        Console.WriteLine("Новая задача добавлена!");
                        break;
                    case 2:
                        int a = 0;
                        Console.WriteLine("-- Нынешние задачи:");
                        if (tasks.Count > 0)
                        {
                            foreach (Task task in tasks)
                            {
                                a++;
                                if (task.IsDone == false)
                                {
                                    Console.WriteLine($"{a}. [] {task.Description}");
                                }
                                else
                                {
                                    Console.WriteLine($"{a}. [X] {task.Description}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Тут пусто!");
                        }

                        break;
                    case 3:
                        Console.WriteLine("-- Введите номер задачи");
                        int userNum = Convert.ToInt32(Console.ReadLine());
                        if (userNum < tasks.Count+1 &&  userNum > 0)
                        {
                            tasks[userNum-1].IsDone = true;
                            Console.WriteLine("Задача теперь выполнена!");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Нет задачи с таким номером!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Выходим...");
                        return;
                }
            }
        }
    }
}