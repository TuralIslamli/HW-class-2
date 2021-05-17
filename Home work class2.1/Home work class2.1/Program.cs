using System;

namespace Home_work_class2._1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;


        class Student
        {
            private string surname;
            private int courseOfStudy;
            private Guid bookNum;
            Student[] students;
            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }


            public int CourseOfStudy
            {
                get { return courseOfStudy; ; }
                set { courseOfStudy = value; }
            }

            public Guid BookNum
            {
                get { return bookNum; }
                set { bookNum = value; }
            }

            public Student()
            {
                students = new Student[100];

            }
            public Student(string surname, int courseOfStudy, Guid bookNum)
            {
                Surname = surname;
                CourseOfStudy = courseOfStudy;
                BookNum = bookNum;
            }
            public Student this[int index]
            {
                get
                {
                    return students[index];
                }
                set
                {
                    students[index] = value;
                }
            }
            public virtual void Print()
            {
                Console.WriteLine($"фамилия:{surname}, курс обучения:{courseOfStudy}, номер зачетной книги:{bookNum}");
            }



        }
        class Aspirant : Student
        {
            private string candidate;
            Aspirant[] aspirants;




            public string Candidate
            {
                get { return candidate; }
                set { candidate = value; }
            }

            public Aspirant(string candidate, string surname, int courseOfStudy, Guid bookNum) : base(surname, courseOfStudy, bookNum)
            {
                Candidate = candidate;
            }
            public Aspirant() : base()
            {
                aspirants = new Aspirant[100];

            }
            public new Aspirant this[int index]
            {
                get
                {
                    return aspirants[index];
                }
                set
                {
                    aspirants[index] = value;
                }
            }
            public override void Print()
            {
                Console.WriteLine($"фамилия:{Surname}, курс обучения:{CourseOfStudy}, номер зачетной книги:{BookNum}, desertacia:{candidate}");
            }


        }
        class Program
        {
            public static void Display()
            {
                Console.WriteLine("1)Добавить Студента");
                Console.WriteLine("2)Добавить Аспиранта");
                Console.WriteLine("3)Вывести количество студентов");
                Console.WriteLine("4)Вывести количество аспирантов");
                Console.WriteLine("5)Вывести список всех студентов");
                Console.WriteLine("6)Вывести список всех аспирантов");
                Console.WriteLine("7)Вывести студента по порядковому индексу");
                Console.WriteLine("8)Вывести аспиранта по порядковому индексу");
                Console.WriteLine("9)Удаление студента по порядковому индексу");
                Console.WriteLine("10)Удаление аспиранта по порядковому индексу");
                Console.WriteLine("11)Exit");
            }
            static void Main(string[] args)
            {
                bool a = false;
                bool b = false;
                int studentQuantity = 0;
                int aspirantQuantity = 0;
                Student student = new Student();
                Aspirant aspirant = new Aspirant();

                do
                {
                    Display();
                    do
                    {
                        Console.Write("Укажите пункт:");
                        string c = Console.ReadLine();
                        switch (c)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Укажите фамилию студента");
                                    string surname = AskSurname();
                                    Console.WriteLine("Укажите курс обучения студента");
                                    int courseOfStudy = Num();
                                    student[studentQuantity] = new Student(surname, courseOfStudy, Guid.NewGuid());
                                    studentQuantity++;
                                    break;
                                }
                            case "2":
                                {


                                    Console.WriteLine("Укажите фамилию аспиранта");
                                    string surname = AskSurname();
                                    Console.WriteLine("Укажите курс обучения аспиранта");
                                    int courseOfStudy = Num();
                                    Console.WriteLine("Введите десертацию:");
                                    string candidate = Console.ReadLine();

                                    aspirant[aspirantQuantity] = new Aspirant(candidate, surname, courseOfStudy, Guid.NewGuid());
                                    aspirantQuantity++;


                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine($"Количество студентов:{studentQuantity}");
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine($"Количество аспирантов:{aspirantQuantity}");
                                    break;
                                }
                            case "5":
                                {
                                    if (studentQuantity == 0)
                                    {
                                        Console.WriteLine("Студентов нет.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < studentQuantity; i++)
                                        {
                                            student[i].Print();
                                        }
                                    }
                                    break;
                                }
                            case "6":
                                {
                                    if (aspirantQuantity == 0)
                                    {
                                        Console.WriteLine("Аспирантов нет.");
                                    }
                                    for (int i = 0; i < aspirantQuantity; i++)
                                    {
                                        aspirant[i].Print();
                                    }
                                    break;
                                }
                            case "7":
                                {
                                    if (studentQuantity == 0)
                                    {
                                        Console.WriteLine("Студентов нет.");
                                    }
                                    else if (studentQuantity != 0)
                                    {


                                        Console.WriteLine("Укажите индекс студента:");
                                        int studentIndex = Index();
                                        if (student[studentIndex] == null)
                                        {
                                            Console.WriteLine("Такого студента нет.");
                                        }
                                        else
                                        {
                                            student[studentIndex].Print();
                                        }
                                    }

                                    break;

                                }
                            case "8":
                                {
                                    if (aspirantQuantity == 0)
                                    {
                                        Console.WriteLine("Аспирантов нет.");
                                    }
                                    else if (aspirantQuantity != 0)
                                    {
                                        Console.WriteLine("Укажите индекс аспиранта:");
                                        int aspirantIndex = Index();
                                        if (aspirant[aspirantIndex] == null)
                                        {
                                            Console.WriteLine("Такого аспиранта нет.:");
                                        }
                                        else
                                        {
                                            aspirant[aspirantIndex].Print();
                                        }
                                    }
                                    break;
                                }
                            case "9":
                                {
                                    if (studentQuantity == 0)
                                    {
                                        Console.WriteLine("Студентов нет.");
                                    }
                                    else if (studentQuantity != 0)
                                    {
                                        Console.WriteLine("Укажите индекс студента, котрого хотите удалить:");
                                        int studentIndex = Index();
                                        student[studentIndex] = null;

                                        Console.WriteLine($"Студент с индексом {studentIndex} удалён.");
                                        for (int i = 0; i < studentQuantity; i++)
                                        {
                                            if (student[i] == null)
                                            {
                                                student[i] = student[i + 1];
                                            }
                                        }
                                        studentQuantity--;
                                    }

                                    break;
                                }
                            case "10":
                                {
                                    if (aspirantQuantity == 0)
                                    {
                                        Console.WriteLine("Аспирантов нет.");
                                    }
                                    else if (aspirantQuantity != 0)
                                    {
                                        Console.WriteLine("Укажите индекс аспиранта, котрого хотите удалить:");
                                        int aspirantIndex = Index();
                                        aspirant[aspirantIndex] = null;
                                        Console.WriteLine($"Аспирант с индексом {aspirantIndex} удалён.");
                                        for (int i = 0; i < aspirantQuantity; i++)
                                        {
                                            if (aspirant[i] == null)
                                            {
                                                aspirant[i] = aspirant[i + 1];
                                            }
                                        }
                                        aspirantQuantity--;
                                    }

                                    break;
                                }
                            case "11":
                                {
                                    b = true;
                                    a = true;
                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Error");
                                    Display();
                                    break;
                                }
                        }

                    } while (b == false);


                } while (a == false);
                Console.WriteLine("До свидания.");
                Console.ReadKey();
            }
            static int Num()
            {
                int num = 0;
                for (; ; )
                {
                    string read1 = (Console.ReadLine());

                    int.TryParse(read1, out num);
                    if (num <= 0)
                    {
                        Console.WriteLine("Не правильно, укажите правильную информацию.");
                    }
                    else
                    {
                        break;
                    }
                }
                return num;

            }
            static int Index()
            {
                int num = 0;
                for (; ; )
                {
                    string read1 = (Console.ReadLine());

                    int.TryParse(read1, out num);
                    if (num < 0)
                    {
                        Console.WriteLine("Не правильно, укажите правильную информацию.");
                    }
                    else
                    {
                        break;
                    }
                }
                return num;

            }
            static string AskSurname()
            {
                bool checkerName = true;
                string personName = "";
                do
                {
                    personName = Console.ReadLine();

                    for (int i = 0; i < personName.Length; i++)
                    {
                        char element = personName[i];

                        if (!Char.IsLetter(element))
                        {
                            checkerName = false;
                            Console.WriteLine("Не корректная информация, укажите правильно: ");
                            break;
                        }
                        else
                        {
                            checkerName = true;
                        }
                    }

                    if (personName.Length < 1)
                    {
                        Console.WriteLine("Не корректная информация, укажите правильно:");
                        checkerName = false;
                    }
                }
                while (checkerName == false);

                return personName;
            }
        }
}


