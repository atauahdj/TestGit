using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSort : MonoBehaviour
{
    [SerializeField] Button _1;
    private bool isButtonClicked = false;
    [SerializeField] Button _2;
    private bool isButtonClicked2 = false;
    [SerializeField] Button _3;
    private bool isButtonClicked3 = false;
    [SerializeField] Button _4;
    private bool isButtonClicked4 = false;
    [SerializeField] Button _5;
    private bool isButtonClicked5 = false;
    [SerializeField] Button _6;
    private bool isButtonClicked6 = false;
    [SerializeField] Button _7;
    private bool isButtonClicked7 = false;
    [SerializeField] Button _8;
    private bool isButtonClicked8 = false;
    [SerializeField] Button _9;
    private bool isButtonClicked9 = false;
    [SerializeField] Button _10;
    private bool isButtonClicked10 = false;
    [SerializeField] TMP_Text winText;

    // Массив кнопок в порядке их расположения на экране
    private Button[] buttonsOrder;

    // Значения на кнопках (соответствуют порядку кнопок)
    private int[] buttonValues = { 1, 5, 3, 2, 7, 4, 6, 8, 10, 9 };

    // Эталонный отсортированный массив
    private int[] sortedValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    void Start()
    {
        // Сохраняем порядок кнопок по их позициям на экране (слева направо)
        SortButtonsByPosition();

        // Обновляем текст на всех кнопках
        UpdateAllButtonTexts();
    }

    void SortButtonsByPosition()
    {
        // Собираем все кнопки в массив
        Button[] allButtons = new Button[] { _1, _2, _3, _4, _5, _6, _7, _8, _9, _10 };

        // Сортируем кнопки по их X координате (слева направо)
        List<Button> buttonList = new List<Button>(allButtons);
        buttonList.Sort((a, b) => a.transform.position.x.CompareTo(b.transform.position.x));

        buttonsOrder = buttonList.ToArray();
    }

    void UpdateAllButtonTexts()
    {
        for (int i = 0; i < buttonsOrder.Length; i++)
        {
            if (buttonsOrder[i] != null)
            {
                SetButtonText(buttonsOrder[i], buttonValues[i]);
            }
        }
    }

    void SetButtonText(Button button, int value)
    {
        Text buttonText = button.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            buttonText.text = value.ToString();
        }
    }

    // Получаем индекс кнопки в порядке расположения
    int GetButtonIndex(Button button)
    {
        for (int i = 0; i < buttonsOrder.Length; i++)
        {
            if (buttonsOrder[i] == button)
                return i;
        }
        return -1;
    }

    public void Button1()
    {
        isButtonClicked = true;
        CheckAndSwap(_1);
    }

    public void Button2()
    {
        isButtonClicked2 = true;
        CheckAndSwap(_2);
    }

    public void Button3()
    {
        isButtonClicked3 = true;
        CheckAndSwap(_3);
    }

    public void Button4()
    {
        isButtonClicked4 = true;
        CheckAndSwap(_4);
    }

    public void Button5()
    {
        isButtonClicked5 = true;
        CheckAndSwap(_5);
    }

    public void Button6()
    {
        isButtonClicked6 = true;
        CheckAndSwap(_6);
    }

    public void Button7()
    {
        isButtonClicked7 = true;
        CheckAndSwap(_7);
    }

    public void Button8()
    {
        isButtonClicked8 = true;
        CheckAndSwap(_8);
    }

    public void Button9()
    {
        isButtonClicked9 = true;
        CheckAndSwap(_9);
    }

    public void Button10()
    {
        isButtonClicked10 = true;
        CheckAndSwap(_10);
    }

    // Получаем первую нажатую кнопку
    private Button GetFirstClickedButton()
    {
        if (isButtonClicked) return _1;
        if (isButtonClicked2) return _2;
        if (isButtonClicked3) return _3;
        if (isButtonClicked4) return _4;
        if (isButtonClicked5) return _5;
        if (isButtonClicked6) return _6;
        if (isButtonClicked7) return _7;
        if (isButtonClicked8) return _8;
        if (isButtonClicked9) return _9;
        if (isButtonClicked10) return _10;
        return null;
    }

    private void CheckAndSwap(Button currentButton)
    {
        Button firstButton = GetFirstClickedButton();

        // Если это первая нажатая кнопка, ничего не делаем
        if (firstButton == currentButton && !IsAnyOtherButtonClicked(currentButton))
            return;

        // Если есть первая нажатая кнопка и она не равна текущей
        if (firstButton != null && firstButton != currentButton)
        {
            // Меняем местами значения в массиве
            int indexA = GetButtonIndex(firstButton);
            int indexB = GetButtonIndex(currentButton);

            if (indexA != -1 && indexB != -1)
            {
                // Меняем значения
                int temp = buttonValues[indexA];
                buttonValues[indexA] = buttonValues[indexB];
                buttonValues[indexB] = temp;

                // Меняем местами кнопки визуально
                SwapButtonPositions(firstButton, currentButton);

                // Обновляем текст на кнопках
                UpdateAllButtonTexts();

                // Меняем цвет
                SetButtonColor(firstButton, Color.yellow);
                SetButtonColor(currentButton, Color.yellow);

                Debug.Log("Текущий массив: " + string.Join(", ", buttonValues));

                // Проверяем сортировку
                if (IsArraySorted())
                {
                    
                    SetAllButtonsColor(Color.green);
                    winText.text = "МАССИВ ОТСОРТИРОВАН)";
                }
            }

            // Сбрасываем все флаги
            ResetAllFlags();
        }
    }

    private bool IsAnyOtherButtonClicked(Button exceptButton)
    {
        if (exceptButton != _1 && isButtonClicked) return true;
        if (exceptButton != _2 && isButtonClicked2) return true;
        if (exceptButton != _3 && isButtonClicked3) return true;
        if (exceptButton != _4 && isButtonClicked4) return true;
        if (exceptButton != _5 && isButtonClicked5) return true;
        if (exceptButton != _6 && isButtonClicked6) return true;
        if (exceptButton != _7 && isButtonClicked7) return true;
        if (exceptButton != _8 && isButtonClicked8) return true;
        if (exceptButton != _9 && isButtonClicked9) return true;
        if (exceptButton != _10 && isButtonClicked10) return true;
        return false;
    }

    private void ResetAllFlags()
    {
        isButtonClicked = false;
        isButtonClicked2 = false;
        isButtonClicked3 = false;
        isButtonClicked4 = false;
        isButtonClicked5 = false;
        isButtonClicked6 = false;
        isButtonClicked7 = false;
        isButtonClicked8 = false;
        isButtonClicked9 = false;
        isButtonClicked10 = false;
    }

    private void SwapButtonPositions(Button buttonA, Button buttonB)
    {
        if (buttonA == null || buttonB == null) return;

        Vector3 tempPosition = buttonA.transform.position;
        buttonA.transform.position = buttonB.transform.position;
        buttonB.transform.position = tempPosition;

        // После обмена позиций обновляем порядок кнопок
        SortButtonsByPosition();
    }

    public void SetButtonColor(Button button, Color color)
    {
        if (button == null) return;

        ColorBlock colors = button.colors;
        colors.normalColor = color;
        colors.selectedColor = color;
        button.colors = colors;
    }

    private bool IsArraySorted()
    {
        for (int i = 0; i < buttonValues.Length - 1; i++)
        {
            if (buttonValues[i] > buttonValues[i + 1])
                return false;
        }
        return true;
    }

    private void SetAllButtonsColor(Color color)
    {
        SetButtonColor(_1, color);
        SetButtonColor(_2, color);
        SetButtonColor(_3, color);
        SetButtonColor(_4, color);
        SetButtonColor(_5, color);
        SetButtonColor(_6, color);
        SetButtonColor(_7, color);
        SetButtonColor(_8, color);
        SetButtonColor(_9, color);
        SetButtonColor(_10, color);
    }
}