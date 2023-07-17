using System.Collections;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator antagonistAnimations;
     
    public void SwapAnimation(string animName)
    {
        antagonistAnimations.Play("Idle");
        StopAllCoroutines();
        antagonistAnimations.Play(animName);
        StartCoroutine(StopAnimation());
    }

    private IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(2f);
        antagonistAnimations.Play("Idle");
    }
}
