int lessonNumber = 1;
int totalLessons = 5;

while (lessonNumber <= totalLessons) {
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber++;
}

Console.WriteLine("Пары закончились");

Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");

int sum = 0;
int count = 0;
Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    sum += grade;
    count++;
    grade = int.Parse(Console.ReadLine());
    if (count > 0) {
        Console.WriteLine($"Средний балл: {(double)sum / count}");
    } else {
        Console.WriteLine("Оценок не было введено");
    }
}
int sum = 0;
int count = 0;
int maxGrade = int.MinValue; 
Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    sum += grade;
    count++;
    if (grade > maxGrade) {
        maxGrade = grade; 
    }
    grade = int.Parse(Console.ReadLine());
}

if (count > 0) {
    Console.WriteLine($"Средний балл: {(double)sum / count:F2}");
    Console.WriteLine($"Наибольшая оценка: {maxGrade}");
} else {
    Console.WriteLine("Оценок не было введено");
}
string correctPassword = "qwerty123";
while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();
    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        break;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова");
}
string correctPassword = "qwerty123";
int attemptCount = 0; 

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        break;
    }

    attemptCount++; 
    Console.WriteLine("Неверный пароль, попробуйте снова");
}

Console.WriteLine($"Количество неудачных попыток: {attemptCount}");

string answer;
do {
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");
    Console.Write("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");
Console.WriteLine("Дневник сохранён");



class Program
{
    static void Main()
    {
        string name;
        int count = 0;

        Console.WriteLine("Вводите имена учеников. Для завершения введите 'конец':");

        name = Console.ReadLine(); 

        while (name != "конец")
        {
            count++; 
            name = Console.ReadLine(); 
        }

        Console.WriteLine($"Всего введено имён: {count}");
    }
}


class Program
{
    static void Main()
    {
        int pages;
        int totalPages = 0;

        Console.WriteLine("Вводите количество страниц, прочитанных за день. Для завершения введите -1:");

        pages = int.Parse(Console.ReadLine()); 

        while (pages != -1)
        {
            totalPages += pages; 
            pages = int.Parse(Console.ReadLine()); 
        }

        Console.WriteLine($"Всего прочитано страниц: {totalPages}");
    }
}
