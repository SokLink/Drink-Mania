using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToAlcoholDetection : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;
    [SerializeField] private PlayerAlcoholAnimations playerAlcoholAnimations;
    [SerializeField] private AlcoholScoreDecreaser alcoholScoreDecreaser;

    public void OnPointerClick(PointerEventData eventData)
    {
        AlcoholScoreEncreaserController();
        PlayerAlcoholAnimationsController();
        AlcoholScoreDecreaserController();
    }

    private void AlcoholScoreEncreaserController()
    {
        alcoholScoreEncreaser.Encreser();
    }

    private void PlayerAlcoholAnimationsController()
    {
        playerAlcoholAnimations.StopAllCoroutines();
        playerAlcoholAnimations.PlayerStartDrinkAlcoholAnimation();
    }

    private void AlcoholScoreDecreaserController()
    {
        alcoholScoreDecreaser.StopAllCoroutines();
        alcoholScoreDecreaser.StartCoroutine(alcoholScoreDecreaser.Decreaser());
    }
}
