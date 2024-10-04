using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в текстовый квест!");
        Console.WriteLine("Вы находитесь в таинственном лесу.");

        // Проверка готовности начать квест
        Console.WriteLine("Вы готовы начать квест? (да/нет)");
        string answer = Console.ReadLine().ToLower();

        while (answer != "да" && answer != "нет")
        {
            Console.WriteLine("Пожалуйста, ответьте 'да' или 'нет'.");
            answer = Console.ReadLine().ToLower();
        }

        if (answer == "да")
        {
            Console.WriteLine("Отлично! Приступим к квесту");
        }
        else
        {
            Console.WriteLine("Жаль, будем вас ждать");
            return;  // Завершаем игру, если ответ "нет"
        }

        int lives = 3;

        Console.WriteLine("На вашем пути появляется огромный волк.");
        Console.WriteLine("'Выбери свою судьбу: Математика, Физика или Информатика. Твое решение определит, какой вопрос ты получишь!'");

        // Выбор предмета с проверкой корректности ввода
        Console.Write("Что ты выберешь? ");
        string choice = Console.ReadLine().ToLower();

        while (choice != "математика" && choice != "физика" && choice != "информатика")
        {
            Console.WriteLine("Пожалуйста, выберите один из предметов: Математика, Физика или Информатика.");
            choice = Console.ReadLine().ToLower();
        }

        // Флаг для отслеживания правильности ответов
        bool firstQuestionAnswered = false;

        while (!firstQuestionAnswered && lives > 0)
        {
            switch (choice)
            {
                case "математика":
                    Console.WriteLine("Вы выбрали Математику. Вопрос: Сколько будет 5 + 5(-1)?");
                    string mathAnswer = Console.ReadLine();

                    // Проверка, что введено число
                    while (!int.TryParse(mathAnswer, out _))
                    {
                        Console.WriteLine("Пожалуйста, введите числовой ответ.");
                        mathAnswer = Console.ReadLine();
                    }

                    if (mathAnswer == "0")
                    {
                        Console.WriteLine("Верно!");
                        firstQuestionAnswered = true;
                    }
                    else
                    {
                        lives--;
                        Console.WriteLine($"Неправильно, ответ 0. Ваши жизни: {lives}");
                        if (lives > 0)
                        {
                            Console.WriteLine("Попробуйте снова.");
                        }
                    }
                    break;

                case "информатика":
                    Console.WriteLine("Вы выбрали Информатику. Вопрос: Какое свойство степени числа 2 делает его результат всегда представимым в двоичной системе как числа вида 1, 10, 100, 1000?");
                    Console.WriteLine("1. Число 2 в любой степени всегда равно 10.");
                    Console.WriteLine("2. Степени числа 2 всегда равны целым числам.");
                    Console.WriteLine("3. Степени числа 2 в двоичной системе всегда представляются как 1 с нулями справа.");
                    Console.WriteLine("4. Степени числа 2 всегда кратны десяти.");
                    string informaticsAnswer = Console.ReadLine();

                    // Проверка, что введен номер ответа от 1 до 4
                    while (informaticsAnswer != "1" && informaticsAnswer != "2" && informaticsAnswer != "3" && informaticsAnswer != "4")
                    {
                        Console.WriteLine("Пожалуйста, введите номер ответа от 1 до 4.");
                        informaticsAnswer = Console.ReadLine();
                    }

                    if (informaticsAnswer == "3")
                    {
                        Console.WriteLine("Правильно!");
                        firstQuestionAnswered = true;
                    }
                    else
                    {
                        lives--;
                        Console.WriteLine($"Неправильно, правильный ответ: 3. Ваши жизни: {lives}");
                        if (lives > 0)
                        {
                            Console.WriteLine("Попробуйте снова.");
                        }
                    }
                    break;

                case "физика":
                    Console.WriteLine("Вы выбрали Физику. Вопрос: Как называется сила, которая тянет объекты к земле?");
                    string physicsAnswer = Console.ReadLine().ToLower();

                    if (physicsAnswer == "гравитация" || physicsAnswer == "сила тяжести")
                    {
                        Console.WriteLine("Правильно!");
                        firstQuestionAnswered = true;
                    }
                    else
                    {
                        lives--;
                        Console.WriteLine($"Неправильно, ответ — гравитация. Ваши жизни: {lives}");
                        if (lives > 0)
                        {
                            Console.WriteLine("Попробуйте снова.");
                        }
                    }
                    break;
            }

            // Проверка, нужно ли продолжать задавать вопрос
            if (!firstQuestionAnswered && lives > 0)
            {
                Console.WriteLine("Давайте попробуем еще раз.");
            }
        }

        if (lives <= 0)
        {
            Console.WriteLine("К сожалению, попытки закончились. Вы не прошли лес.");
            return;  // Игра заканчивается, если закончились жизни
        }

        // Лесник
        Console.WriteLine("Вас встречает лесник.");
        Console.WriteLine("'Я не люблю незваных гостей,' — говорит он, — 'особенно тех, кто осмеливается бродить по моим лесам без приглашения.'");
        Console.WriteLine("Лесник хитро улыбается и задаёт вам задачу: 'Сколько деревьев будет в моём лесу через 5 лет?'");

        // Параметры задачи
        int initialTrees = 100;
        int yearsToPass = 5;
        int treesPlantedPerYear = 10;
        int treesLostPerYear = 5;

        int correctAnswer = initialTrees + (treesPlantedPerYear - treesLostPerYear) * yearsToPass;

        bool secondQuestionAnswered = false;

        while (!secondQuestionAnswered && lives > 0)
        {
            // Ввод ответа
            int parsedAnswer = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Введите ваш ответ (целое число): ");
                string userAnswer = Console.ReadLine();

                if (int.TryParse(userAnswer, out parsedAnswer))
                {
                    isValidInput = true;  // Выход из цикла
                }
                else
                {
                    Console.WriteLine("Ошибка! Пожалуйста, введите целое число.");
                }
            }

            // Проверка ответа
            if (parsedAnswer == correctAnswer)
            {
                Console.WriteLine($"Лесник: 'Хм, а ты неплох. Правильно, через 5 лет будет {correctAnswer} деревьев.'");
                Console.WriteLine("'Проходи дальше.'");
                secondQuestionAnswered = true;
            }
            else
            {
                lives--;
                Console.WriteLine($"Лесник: 'Неправильно. Правильный ответ: {correctAnswer} деревьев.'");
                Console.WriteLine($"Ваши жизни: {lives}");
                if (lives > 0)
                {
                    Console.WriteLine("'Попробуй снова!'");
                }
            }
        }

        if (lives <= 0)
        {
            Console.WriteLine("Ваши попытки закончились. Игра окончена.");
            return;  // Завершение игры, если больше нет жизней
        }

        // Завершение игры
        Console.WriteLine("Поздравляем! Вы успешно завершили квест.");
    }
}
