using UnityEngine;

public class SwapAlcoholAndAntagonist : MonoBehaviour
{
    [SerializeField] private Shop shop;

    [SerializeField] private SpriteRenderer playerAlcoholSprite;
    [SerializeField] private SpriteRenderer antagonistAlcoholSprite;
    [SerializeField] private SpriteRenderer antagonistSprite;

    [SerializeField] private Sprite VhiskeySprite;
    [SerializeField] private Sprite RumSprite;
    [SerializeField] private Sprite TequilaSprite;
    [SerializeField] private Sprite MoonshineSprite;

    [SerializeField] private Sprite cowboy;
    [SerializeField] private Sprite pirat;
    [SerializeField] private Sprite mexican;
    [SerializeField] private Sprite russian;

    [SerializeField] private Sprite drunkDworf;
    [SerializeField] private Sprite drunkCowboy;
    [SerializeField] private Sprite drunkPirat;
    [SerializeField] private Sprite drunkMexican;

    public void Swap(int nextLvl)
    {
        switch(nextLvl)
        {
            case 11:
                playerAlcoholSprite.sprite = VhiskeySprite;
                antagonistAlcoholSprite.sprite = VhiskeySprite;

                antagonistSprite.sprite = cowboy;
                break;

            case 21:
                playerAlcoholSprite.sprite = RumSprite;
                antagonistAlcoholSprite.sprite = RumSprite;

                antagonistSprite.sprite = pirat;
                break;

            case 31:
                playerAlcoholSprite.sprite = TequilaSprite;
                antagonistAlcoholSprite.sprite = TequilaSprite;

                antagonistSprite.sprite = mexican;
                break;

            case 41:
                playerAlcoholSprite.sprite = MoonshineSprite;
                antagonistAlcoholSprite.sprite = MoonshineSprite;

                antagonistSprite.sprite = russian;
                break;

            case 6:
                antagonistSprite.sprite = drunkDworf;
                break;

            case 16:
                antagonistSprite.sprite = drunkCowboy;
                break;

            case 26:
                antagonistSprite.sprite = drunkPirat;
                break;

            case 36:
                antagonistSprite.sprite = drunkMexican;
                break;
        }
    }
}
