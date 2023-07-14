using UnityEngine;

public class SwapAlcohol : MonoBehaviour
{
    [SerializeField] private Shop shop;

    [SerializeField] private SpriteRenderer playerAlcoholSprite;

    [SerializeField] private Sprite VhiskeySprite;
    [SerializeField] private Sprite RumSprite;
    [SerializeField] private Sprite TequilaSprite;
    [SerializeField] private Sprite MoonshineSprite;

    public void Swap(int nextLvl)
    {
        switch(nextLvl)
        {
            case 11:
                playerAlcoholSprite.sprite = VhiskeySprite;
                break;

            case 21:
                playerAlcoholSprite.sprite = RumSprite;
                break;

            case 31:
                playerAlcoholSprite.sprite = TequilaSprite;
                break;

            case 41:
                playerAlcoholSprite.sprite = MoonshineSprite;
                break;
        }
    }
}
