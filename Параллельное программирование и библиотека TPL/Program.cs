using static System.Console;
/*
Task task1 = Task.Run(() => WriteLine("Hello"));
Task task2 = Task.Factory.StartNew(() => WriteLine("Task2"));
Task task=new Task(()=>
{
    WriteLine("Hello Task");
    Thread.Sleep(1000);
    WriteLine("end task");

});
task.Start();

task.Wait();
task1.Wait();
task2.Wait();
*/
/*WriteLine("Main Starts");
Task task2 = new Task(() => WriteLine("hello"));

Task task1 = new Task(() =>
{
    WriteLine("Task Start");
    Thread.Sleep(1000);
    WriteLine("Task End");
   
});
task1.RunSynchronously();
task2.Start();
WriteLine("Main End");*/
/*Task task1 = new Task(() =>
{
    WriteLine($"Task{Task.CurrentId} Starts");
    Thread.Sleep( 1000 );
    WriteLine($"Task {Task.CurrentId} Ends");
});
task1.Start();
WriteLine($"task1 Id: {task1.Id}");
WriteLine($"task1 is Completed:{task1.IsCompleted}");
WriteLine($"task1 Status: {task1.Status}");


task1.Wait();*/
/*//for(int i = 0; i < 4; i++)
//{
//    Reader reader = new Reader(i);
//}
//class Reader
//{
//    //Создаем семафор
//    static Semaphore sem = new Semaphore(2, 2);
//    Thread myThread;
//    int count = 3;

//    public Reader(int i)
//    {
//        myThread = new Thread(Read);
//        myThread.Name = $"Посетитель{i}";
//        myThread.Start();
//    }

//    public void Read()
//    {
//        while(count>0)
//        {
//            sem.WaitOne();
//            WriteLine($"{Thread.CurrentThread.Name} заходит в магазин");
//            WriteLine($"{Thread.CurrentThread.Name} ходит по магазину");
//            Thread.Sleep(1000);
//            WriteLine($"{Thread.CurrentThread.Name} уходит из магазина");
//            sem.Release();

//            count--;
//            Thread.Sleep(1000);
//        }
//    }
//}*/
//Работа с классом Task
//Вложенные задачи
/*//var outer = Task.Factory.StartNew(() => //внешняя задача
//{
//    WriteLine("Outer task starting...");
//    var inner = Task.Factory.StartNew(() =>//вложенная задача
//    {
//        WriteLine("Inner task starting...");
//        Thread.Sleep(2000);
//        WriteLine("Inner task finished.");
//    },TaskCreationOptions.AttachedToParent);//Выполнение вложенной задачи, как части внешней
//});
//outer.Wait();
//WriteLine("End of Main");*/
//массив задач 1 вариант
/*//Task[] tasks1 = new Task[3]
//{
//    new Task(() => WriteLine("First Task")),
//    new Task(() => WriteLine("Second Task")),
//    new Task(() => WriteLine("Third Task")),
//};
////запуск задач в массиве
//foreach (var t in tasks1)
//    t.Start();
//второй способ
//Task[] tasks2 = new Task[3];
//int j = 1;
//for (int i = 0; i < tasks2.Length; i++)
//    tasks2[i] = Task.Factory.StartNew(() => WriteLine($"Task {j++}"));
//Task[] tasks = new Task[3];
//for(var i=0;i<tasks.Length;i++)
//{
//    tasks[i] = new Task(() =>
//    {
//        Thread.Sleep(1000);//эмуляция долгой работы
//        WriteLine($"Task{i} finished");
//    });
//    tasks[i].Start(); //запускаем задачу
//}
//WriteLine("Завершение метода Main");
//Task.WaitAll(tasks1);*/
//Возвращение результатов из задач
/*//int n1 = 4, n2 = 5;
//Task<int> sumTask = new Task<int>(() => Sum(n1, n2));
//sumTask.Start();

//int result = sumTask.Result;
//WriteLine($"{n1} + {n2} = {result}");

//int Sum(int a, int b) => a + b;*/
/*//Task<Person> defaultPersonTask = new Task<Person>(() => new Person("Ted", 28));
//defaultPersonTask.Start();
//Person defaultPerson = defaultPersonTask.Result;
//WriteLine($"{defaultPerson.Name} - {defaultPerson.Age}");
//record Person (string Name, int Age);*/
//Задачи продолжения
//без возвращаемых параметров
/*//Task task1 = new Task(() =>
//{
//    WriteLine($"Id задачи: {Task.CurrentId}");
//});
////задача продолжения - task2 выполнения после task1
//Task task2 = task1.ContinueWith(PrintTask);
//task1.Start();

////ждем окончания второй задачи
//task2.Wait();
//WriteLine("Конец метод Main");

//void PrintTask(Task t)
//{
//    WriteLine($"Id задачи: {Task.CurrentId}");
//    WriteLine($"Id предыдуший задачи: {t.Id}");
//    Thread.Sleep(3000);
//}*/
//С возвращаемыми параметрами
/*//Task<int> sumTask = new Task<int>(() => Sum(7, 9));

////задача продолжения
//Task printTask = sumTask.ContinueWith(task => PrintResult(task.Result));
//sumTask.Start();

////ждем окончания второй задачи
//printTask.Wait();
//WriteLine("Конец метода Main");

//int Sum(int a, int b) => a + b;
//void PrintResult(int sum) => WriteLine($"Sum: {sum}");*/
//Цепочка последовательно выполняющихся задач
/*//Task task1 = new Task(() => WriteLine($"Current Task: {Task.CurrentId}"));

////задача продолжения
//Task task2 = task1.ContinueWith(t => WriteLine($"Current Task: {Task.CurrentId} Previous Task: {t.Id}"));
//Task task3 = task2.ContinueWith(t => WriteLine($"Current Task: {Task.CurrentId} Previous Task: {t.Id}"));
//Task task4 = task3.ContinueWith(t => WriteLine($"Current Task: {Task.CurrentId} Previous Task: {t.Id}"));

//task1.Start();
//task4.Wait();
//WriteLine("Конец метода Main");*/
//класс Parellel
//метод Parallel.Invoke выполняет три метода
/*//Parallel.Invoke(
//    Print,
//    () =>
//    {
//        WriteLine($"Выполняет задача {Task.CurrentId}");
//        Thread.Sleep(1000);
//    },
//    () => Square(5));
//void Print()
//{
//    WriteLine($"Выполняет задача {Task.CurrentId}");
//    Thread.Sleep(1000);
//}
//void Square(int n)
//{
//    WriteLine($"Выполняет задача {Task.CurrentId}");
//    Thread.Sleep(3000);
//    WriteLine($"Результат {n * n}");
//}*/
//метод Parallel.For
/*//Parallel.For(2, 6, Square);//For(int, int, Action<int>)
//void Square(int t)
//{
//    WriteLine($"Выполняется задача {Task.CurrentId}");
//    WriteLine($"Квадрат числа {t} равен {t * t}");
//    Thread.Sleep(2000);
}*/
//метод Parallel.ForEach
/*//ParallelLoopResult result1 = Parallel.ForEach<int>( //ParallelLoopResult ForEach<TSource>(
//    new List<int>() { 1, 3, 5, 8 },                 //IEnumerable<TSource> source, Action<TSource> body)
//    Square);
//void Square(int t)
//{
//    WriteLine($"Выполняется задача {Task.CurrentId}");
//    WriteLine($"Квадрат числа {t} равен {t * t}");
//    Thread.Sleep(2000);
//}*/
/*//ParallelLoopResult result1 = Parallel.For(1, 10, Square);
//if (!result1.IsCompleted)
//    WriteLine($"Выполнение циклазавершено на операции {result1.LowestBreakIteration}");
//void Square(int t1, ParallelLoopState pls1)
//{
//    //WriteLine($"Выполняется задача {Task.CurrentId}");
//    if (t1 == 5) pls1.Break();
//    WriteLine($"Квадрат числа {t1} равен {t1 * t1}");
//    Thread.Sleep(2000);
//}*/
