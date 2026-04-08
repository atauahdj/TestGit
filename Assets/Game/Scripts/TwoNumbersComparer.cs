using TMPro;
using UnityEngine;

public class TwoNumbersComparer : MonoBehaviour {
    [SerializeField] private TMP_InputField _inputFieldFirstValue;
    [SerializeField] private TMP_InputField _inputFieldSecondValue;
    [SerializeField] private TMP_InputField _inputFieldResultValue;

    public void OnCompareButton() {
        if (_inputFieldFirstValue.text == "") {
            _inputFieldResultValue.text = "First value bad!";
            return;
        }
        if (_inputFieldSecondValue.text == "") {
            _inputFieldResultValue.text = "Second value bad!";
            return;
        }
        if (double.TryParse(_inputFieldFirstValue.text, out double firstValue) && 
            double.TryParse(_inputFieldSecondValue.text, out double secondValue)) {
            if (firstValue > secondValue) {
                _inputFieldResultValue.text = _inputFieldFirstValue.text;
            }
            else if (secondValue > firstValue) {
                _inputFieldResultValue.text = _inputFieldSecondValue.text;
            }
            else {
                _inputFieldResultValue.text = "Equals!";
            }
        } else {
            _inputFieldResultValue.text = "Bad numbers!";
        }
    }
}
