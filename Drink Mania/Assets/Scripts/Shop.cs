using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;
    [SerializeField] private AlcoholScoreCounter alcoholScoreCounter;
    [SerializeField] private UIController uIController;
    [SerializeField] private SwapAlcohol swapAlcohol;
    [SerializeField] private PlayerAlcoholAnimations playerAlcoholAnimations;
    [SerializeField] private ClickZoneChange clickZoneChange;

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

                clickZoneChange.DecreaseClickZoneScale();

                swapAlcohol.Swap(nextLvl);
                playerAlcoholAnimations.isBeer = false;
            }

            else if (nextLvl >= 51)
            {

            }

            else
            {
                alcoholScoreEncreaser.encreaseMagnitude += 1;
                alcoholScoreCounter.alcoholScore -= price;

                clickZoneChange.DecreaseClickZoneScale();
            }

            nextLvl = alcoholScoreEncreaser.encreaseMagnitude + 1;
            price = alcoholScoreEncreaser.encreaseMagnitude * _priceModificator;

            uIController.ShopUIController(nextLvl, price);
        }
    }
}
