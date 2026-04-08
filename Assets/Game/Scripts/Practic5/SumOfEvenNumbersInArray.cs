using System.Linq;
using UnityEngine;
public class SumOfEvenNumbersInArray : MonoBehaviour {
    /// <summary>
    /// Метод обработки события OnClick кнопки "Сумма четных чисел в заданном массиве"
    /// </summary>
    public void OnSumEvenNumbersInArray() {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
    }
    /// <summary>
    /// Метод вычисляет сумму четных чисел в массиве 
    /// </summary>
    /// <param name="array">Исходный массив чисел</param>
    /// <returns>Сумма чисел четных чисел</returns>
    private int SumEvenNumbersInArray(int[] array) {
        // Реализуйте подсчет четных чисел используя цикл и
        // верните вместо 0 полученный результат 
        int total = 0;
        foreach (int value in array) {
            if (value % 2 == 0) {
                total += value;
            }
        }
        return total;
    }
}