using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;
    [SerializeField] private AlcoholScoreCounter alcoholScoreCounter;
    [SerializeField] private UIController uIController;
    [SerializeField] private SwapAlcohol swapAlcohol;
    [SerializeField] private PlayerAlcoholAnimations playerAlcoholAnimations;

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
                alcoholScoreEncreaser._encreaseMagnitude += 1;
                alcoholScoreCounter.alcoholScore -= price;

                swapAlcohol.Swap(nextLvl);
                playerAlcoholAnimations.isBeer = false;
            }

            else
            {
                alcoholScoreEncreaser._encreaseMagnitude += 1;
                alcoholScoreCounter.alcoholScore -= price;
            }

            nextLvl = alcoholScoreEncreaser._encreaseMagnitude + 1;
            price = alcoholScoreEncreaser._encreaseMagnitude * _priceModificator;

            uIController.ShopUIController(nextLvl, price);
        }
    }
}
