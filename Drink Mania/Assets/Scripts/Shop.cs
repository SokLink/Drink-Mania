using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;
    [SerializeField] private AlcoholScoreCounter alcoholScoreCounter;
    [SerializeField] private UIController uIController;
    [SerializeField] private SwapAlcoholAndAntagonist swapAlcoholAndAntagonist;
    [SerializeField] private PlayerAlcoholAnimations playerAlcoholAnimations;
    [SerializeField] private ClickZoneChange clickZoneChange;
    [SerializeField] private Dialogues dialogues;
    [SerializeField] private DrinkParticles drinkParticles;

    [NonSerialized] public int nextLvl = 2;
    [NonSerialized] public float price = 1;

    private float _priceModificator = 1f;

    private void Start()
    {
        uIController.ShopUIController(nextLvl, price);
    }

    public void UpgradePlayer()
    {
        if (alcoholScoreCounter.alcoholScore >= price)
        {
            if (nextLvl == 11 || nextLvl == 21 || nextLvl == 31 || nextLvl == 41)
            {
                alcoholScoreEncreaser.encreaseMagnitude += 1;
                alcoholScoreCounter.alcoholScore -= price;

                swapAlcoholAndAntagonist.Swap(nextLvl);
                drinkParticles.SwapDrinkParticles(nextLvl);

                playerAlcoholAnimations.isBeer = false;
            }

            else if (nextLvl == 6 || nextLvl == 16 || nextLvl == 26 || nextLvl == 36)
            {
                alcoholScoreEncreaser.encreaseMagnitude += 1;
                alcoholScoreCounter.alcoholScore -= price;

                swapAlcoholAndAntagonist.Swap(nextLvl);
            }

            else if (nextLvl >= 51)
            {

            }

            else
            {
                alcoholScoreEncreaser.encreaseMagnitude += 1;
                alcoholScoreCounter.alcoholScore -= price;
            }

            nextLvl = alcoholScoreEncreaser.encreaseMagnitude + 1;
            price = alcoholScoreEncreaser.encreaseMagnitude * _priceModificator;

            uIController.ShopUIController(nextLvl, price);

            clickZoneChange.DecreaseClickZoneScale();
            dialogues.PlayDialogues(nextLvl - 1);
        }
    }
}
