using UnityEngine;

public class EscMenusController : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject escMenu;

    private bool _escMenuSetActive = false;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && startMenu.active == false)
        {
            _escMenuSetActive = !_escMenuSetActive;
            escMenu.SetActive(_escMenuSetActive);
        }
    }

    public void ResumeButton()
    {
        escMenu.SetActive(false);
    }

    public void FromEscMenuToMenuButton(GameObject menu)
    {
        escMenu.SetActive(false);
        menu.SetActive(true);
    }

    public void BackToEscMenuButton(GameObject menu)
    {
        menu.SetActive(false);
        escMenu.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
