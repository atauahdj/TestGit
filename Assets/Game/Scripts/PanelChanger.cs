using UnityEngine;

public class PanelChanger : MonoBehaviour {
    [SerializeField] private GameObject _currentPanel;

    public void ChangePanel(GameObject panelToChange) {
        if (_currentPanel != null) {
            _currentPanel.SetActive(false);
            panelToChange.SetActive(true);
            _currentPanel = panelToChange;
        }
    }
}
