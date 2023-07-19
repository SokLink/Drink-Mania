using System.Collections;
using UnityEngine;

public class SwapAlcoholAndAntagonist : MonoBehaviour
{
    [SerializeField] private Shop shop;
    [SerializeField] private AnimationController animationController;

    [SerializeField] private Animator enemyAlcoholSpriteAnimator;
    [SerializeField] private SpriteRenderer enemyAlcoholSpriteSpriteRenderer;

    [SerializeField] private SpriteRenderer playerAlcoholSprite;
    [SerializeField] private SpriteRenderer antagonistAlcoholSprite;
    [SerializeField] private SpriteRenderer antagonistSprite;

    [SerializeField] private Sprite BeerSprite;
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
                enemyAlcoholSpriteAnimator.enabled = false;
                enemyAlcoholSpriteSpriteRenderer.sprite = BeerSprite;

                playerAlcoholSprite.sprite = VhiskeySprite;

                StartCoroutine(AntagonistSwap(cowboy, VhiskeySprite));
                break;

            case 21:
                playerAlcoholSprite.sprite = RumSprite;

                StartCoroutine(AntagonistSwap(pirat, RumSprite));
                break;

            case 31:
                playerAlcoholSprite.sprite = TequilaSprite;

                StartCoroutine(AntagonistSwap(mexican, TequilaSprite));
                break;

            case 41:
                playerAlcoholSprite.sprite = MoonshineSprite;

                StartCoroutine(AntagonistSwap(russian, MoonshineSprite));
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

    private IEnumerator AntagonistSwap(Sprite newAntagonistSprite, Sprite newAlcoholSprite)
    {
        animationController.SwapAnimation("Fall", false);

        yield return new WaitForSeconds(1.5f);

        antagonistSprite.sprite = newAntagonistSprite;
        antagonistAlcoholSprite.sprite = newAlcoholSprite;

        animationController.dontDrinkAnimName = "CowboyDontDrinkBottle";
        animationController.startDrinkAnimName = "CowboyDrinkBottle";

        animationController.SwapAnimation("Change", false);
    }
}
