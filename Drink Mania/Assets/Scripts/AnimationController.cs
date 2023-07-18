using System.Collections;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator antagonistAnimations;
    [SerializeField] private Animator antagonistAlcoholAnimations;

    [SerializeField] private ParticleSystem enemyDrinkParticleSystem;

    public void SwapAnimation(string animName)
    {
        antagonistAnimations.Play("Idle");
        antagonistAlcoholAnimations.Play("DworfDontDrink");
        StopAllCoroutines();

        enemyDrinkParticleSystem.emissionRate = 0f;
        antagonistAnimations.Play(animName);
        StartCoroutine(StopAnimation());
    }

    private IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(2f);

        antagonistAnimations.Play("Idle");
        antagonistAlcoholAnimations.Play("DrinkDwor");

        StartCoroutine(EnemyDrinkParticles());
    }

    private IEnumerator EnemyDrinkParticles()
    {
        yield return new WaitForSeconds(0.4f);

        enemyDrinkParticleSystem.emissionRate = 100f;
    }
}
