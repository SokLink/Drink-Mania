using System;
using System.Collections;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator antagonistAnimations;
    [SerializeField] private Animator antagonistAlcoholAnimations;
    [SerializeField] private Animator antagonistAlcoholSpriteAnimations;

    [SerializeField] private ParticleSystem enemyDrinkParticleSystem;

    [NonSerialized] public string dontDrinkAnimName = "DworfDontDrinkBeer";
    [NonSerialized] public string startDrinkAnimName = "DworfDrinkBeer";

    public void SwapAnimation(string animName, bool isFromStart)
    {
        if(isFromStart)
        {
            antagonistAnimations.Play("Idle");
            StopAllCoroutines();

            enemyDrinkParticleSystem.emissionRate = 0f;
            antagonistAnimations.Play(animName);
            StartCoroutine(StopAnimation());
        }
        else
        {
            antagonistAnimations.Play("Idle");
            antagonistAlcoholAnimations.Play(dontDrinkAnimName);
            antagonistAlcoholSpriteAnimations.Play("BeerSpriteChangeReverse");
            StopAllCoroutines();

            enemyDrinkParticleSystem.emissionRate = 0f;
            antagonistAnimations.Play(animName);
            StartCoroutine(StopAnimation());
        }
    }

    private IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(1.5f);

        antagonistAnimations.Play("Idle");
        antagonistAlcoholAnimations.Play(startDrinkAnimName);
        antagonistAlcoholSpriteAnimations.Play("BeerSpriteChange");

        StartCoroutine(EnemyDrinkParticles());
    }

    private IEnumerator EnemyDrinkParticles()
    {
        yield return new WaitForSeconds(0.4f);

        enemyDrinkParticleSystem.emissionRate = 50f;
    }
}
