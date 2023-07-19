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
    [SerializeField] private AlcoholScoreDecreaser alcoholScoreDecreaser;

    [NonSerialized] public int nextLvl = 2;
    [NonSerialized] public float price = 100;

    private int _priceModificator = 100;
    private int _scoreEncreaserModificator = 1;

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
                alcoholScoreEncreaser.lvl += 1;

                alcoholScoreCounter.alcoholScore -= price;

                swapAlcoholAndAntagonist.Swap(nextLvl);
                drinkParticles.SwapDrinkParticles(nextLvl);

                playerAlcoholAnimations.isBeer = false;

                alcoholScoreDecreaser._decreaseMagnitude += 1;
            }

            else if (nextLvl == 6 || nextLvl == 16 || nextLvl == 26 || nextLvl == 36)
            {
                alcoholScoreEncreaser.lvl += 1;
                alcoholScoreCounter.alcoholScore -= price;

                swapAlcoholAndAntagonist.Swap(nextLvl);
            }

            else if (nextLvl >= 51)
            {
                return;
            }

            else
            {
                alcoholScoreEncreaser.lvl += 1;
                alcoholScoreCounter.alcoholScore -= price;
            }

            UpgradeEncreaseMagnitude();

            nextLvl = alcoholScoreEncreaser.lvl + 1;
            price = alcoholScoreEncreaser.encreaseMagnitude * _priceModificator;

            uIController.ShopUIController(nextLvl, price);

            clickZoneChange.DecreaseClickZoneScale();
            dialogues.PlayDialogues(nextLvl - 1);
        }
    }

    private void UpgradeEncreaseMagnitude()
    {
        if(nextLvl == 11)
        {
            _scoreEncreaserModificator = 10;
        }

        if (nextLvl == 31)
        {
            _scoreEncreaserModificator = 100;
        }

        if (nextLvl == 41)
        {
            _scoreEncreaserModificator = 100;
        }

        alcoholScoreEncreaser.encreaseMagnitude += _scoreEncreaserModificator;
    }
}
