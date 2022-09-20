void FillArray(int[] collection) //объявляем массив collection
// void -метод, - это метод, который ничего не возвращает. 
// return в коде не должно быть
{
    int length = collection.Length; // поучаем длинну массива collection
    int index = 0;
    while (index < length)
    {
        collection[index]=new Random().Next(1, 10);//обращаемся к аргументу collection
        // на позицию index и кладем туда случайное целое число из диапазона 1-10.
        index++;
    }
}
void PrintArray(int[] col) // метод void, который печатает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// если искомого элемента нет, по умолчанию будет выдаваться
    // позиция -4 

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index; // находим первую позицицию заданного числа
            break; // преращаем поиск. останавливаем проверку
        }
        index++; //щелкаем индесы
    }
    return position;
}

int[] array = new int[10]; // создаем новый массив, в котором 10 элементов
FillArray(array); // заполняем массив
array [4] = 4; // принудительно добавляем в массив четверку на позицию 4
PrintArray(array); // распечатываем массив
Console.WriteLine(); // выводим пустую строчку, чтобы отделить вывод массива

int pos = IndexOf(array, 4); // определяем переменную pos, в нее кладем 
//результат работы метода IndexOf. В качестве аргумента будет наш массив 
// и ищем в массиве цифру 4 
Console.WriteLine(pos);
