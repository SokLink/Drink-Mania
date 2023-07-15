using UnityEngine;

public class StartMenusController : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject clickZone;

    public void StartButton()
    {
        startPanel.SetActive(false);
        clickZone.SetActive(true);
    }

    public void FromStartToMenuButton(GameObject menu)
    {
        startMenu.SetActive(false);
        menu.SetActive(true);
    }

    public void BackToStartMenuButton(GameObject menu)
    {
        menu.SetActive(false);
        startMenu.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
