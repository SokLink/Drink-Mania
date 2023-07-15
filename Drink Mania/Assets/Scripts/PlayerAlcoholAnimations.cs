using System;
using System.Collections;
using UnityEngine;

public class PlayerAlcoholAnimations : MonoBehaviour
{
    [SerializeField] private Transform alcoholTransform;
    [SerializeField] private SpriteRenderer alcoholSprite;
    [SerializeField] private DrinkParticles drinkParticles;

    [SerializeField] private Sprite playerHoldBeerSprite;
    [SerializeField] private Sprite playerDrinkBeerSprite;

    [NonSerialized] public bool isBeer = true;

    private float _drinkTime = 0.5f;

    private Vector2 _originAlcoholPosition = new Vector2(4.5f, -1.5f);
    private Vector2 _alcoholMoveTo = new Vector2(0f, -2.25f);
    private Vector2 _beerMoveTo = new Vector2(0f, -4f);

    private Vector2 _originAlcoholScale = new Vector2(1f, 1f);
    private Vector2 _alcogolScaleTo = new Vector2(2f, -2f);
    private Vector2 _beerScaleTo = new Vector2(2f, 2f);

    public void PlayerStartDrinkAlcoholAnimation()
    {
        if(isBeer)
        {
            alcoholTransform.position = _beerMoveTo;

            alcoholSprite.sprite = playerDrinkBeerSprite;
            alcoholTransform.localScale = _beerScaleTo;
        }
        else
        {
            alcoholTransform.position = _alcoholMoveTo;

            alcoholTransform.localScale = _alcogolScaleTo;
        }

        drinkParticles.EnableAndDisableDrinkParticles(100);
        StartCoroutine(PlayerEndDrinkAlcoholAnimation());
    }

    private IEnumerator PlayerEndDrinkAlcoholAnimation()
    {
        yield return new WaitForSeconds(_drinkTime);

        alcoholTransform.position = _originAlcoholPosition;
        drinkParticles.EnableAndDisableDrinkParticles(0);

        if (isBeer)
        {
            alcoholSprite.sprite = playerHoldBeerSprite;
            alcoholTransform.localScale = _originAlcoholScale;
        }
        else
        {
            alcoholTransform.localScale = _originAlcoholScale;
        }
    }
}
