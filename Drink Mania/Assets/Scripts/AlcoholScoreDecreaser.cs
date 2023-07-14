using System.Collections;
using UnityEngine;

public class AlcoholScoreDecreaser : MonoBehaviour
{
    [SerializeField] private AlcoholScoreCounter alcoholScoreCounter;

    private float _timeBeforeDercrease = 2.5f;
    private float _decreaseTimer = 1f;

    private int _decreaseMagnitude = 1;
    private float _minDecreaseScore = 10f;

    public IEnumerator Decreaser()
    {
        yield return new WaitForSeconds(_timeBeforeDercrease);

        if (alcoholScoreCounter.alcoholScore >= 10f)
        {
            while (true)
            {
                alcoholScoreCounter.alcoholScore = Mathf.Clamp(alcoholScoreCounter.alcoholScore - _decreaseMagnitude, _minDecreaseScore, Mathf.Infinity);

                yield return new WaitForSeconds(_decreaseTimer);
            }
        }
    }
}
