using UnityEngine;

public class ClickZoneChange : MonoBehaviour
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;

    [SerializeField] private Transform clickZoneTransform;
    [SerializeField] private Transform[] pathElements;

    private int targetPathPoint = 0;

    private void FixedUpdate()
    {
        clickZoneTransform.position = Vector3.MoveTowards(clickZoneTransform.position, pathElements[SetTargetPathPoint()].position, (alcoholScoreEncreaser.encreaseMagnitude * 0.25f) * Time.deltaTime);
    }

    private int SetTargetPathPoint()
    {
        if(clickZoneTransform.position == pathElements[targetPathPoint].position)
        {
            if(targetPathPoint + 1 >= pathElements.Length)
            {
                targetPathPoint = 0;
            }

            else
            {
                targetPathPoint += 1;
            }
        }

        return targetPathPoint;
    }

    public void DecreaseClickZoneScale()
    {
        clickZoneTransform.localScale = new Vector2(50f / (alcoholScoreEncreaser.encreaseMagnitude * 0.25f), 50f / (alcoholScoreEncreaser.encreaseMagnitude * 0.25f));
    }
}
