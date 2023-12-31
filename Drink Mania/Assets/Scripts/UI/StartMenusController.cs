using System.Collections;
using UnityEngine;

public class StartMenusController : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject clickZone;

    [SerializeField] private Animator antagonistAlcoholAnimations;
    [SerializeField] private ParticleSystem enemyDrinkParticleSystem;
    [SerializeField] private Animator antagonistAlcoholSpriteAnimations;

    [SerializeField] private AudioManager audioManager;
    [SerializeField] private Dialogues dialogues;

    public void StartButton()
    {
        audioManager.EnviromentalStartOnStart();

        audioManager.SwapToMainMusic();
        animationInStart();

        clickZone.SetActive(true);
        startPanel.SetActive(false);
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

    private void animationInStart()
    {
        dialogues.PlayOnButtonStart(true);

        StartCoroutine(animationInStartCoroutine());
    }

    private IEnumerator animationInStartCoroutine()
    {
        yield return new WaitForSeconds(1.5f);

        antagonistAlcoholAnimations.Play("DworfDrinkBeer");
        antagonistAlcoholSpriteAnimations.Play("BeerSpriteChange");

        yield return new WaitForSeconds(0.4f);

        enemyDrinkParticleSystem.emissionRate = 50f;
    }
}
