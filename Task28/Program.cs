// Задайте массив из 12 элементов, заполненый случайными числами из промежутка
// [-9; 9].Найдите сумму положительных и отрицательных элементов массива.

int negativeSum = 0;
int positiveSum = 0;

int [] array = new int [12];
for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(-9, 9);
}
for(int j = 0; j < array.Length; j++){
    Console.Write(array[j] + " ");
}
Console.WriteLine(" ");
for(int s = 0; s < array.Length; s++){
    if(array[s] < 0) {
        negativeSum = negativeSum + array[s];
    }else{
        positiveSum = positiveSum + array[s];
    }
} 
Console.WriteLine($"The sum of negative numbers is: {negativeSum}.");
Console.WriteLine($"The sum of positive numbers is: {positiveSum}.");
