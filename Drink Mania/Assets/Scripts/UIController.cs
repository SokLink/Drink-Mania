using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;
    [SerializeField] private AlcoholScoreCounter alcoholScoreCounter;
    [SerializeField] private Shop shop;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI shopButtonText;

    private void Update()
    {
        ScoreUIController();
    }

    private void ScoreUIController()
    {
        scoreText.text = "Alcohol Score: " + alcoholScoreCounter.alcoholScore.ToString();
    }

    public void ShopUIController(int nextLvl, float price)
    {
        if (nextLvl == 11 || nextLvl == 21 || nextLvl == 31 || nextLvl == 41)
        {
            shopButtonText.text = "Upgrade alcohol to next (Cost: " + price.ToString() + " AS)";
        }

        else if (nextLvl >= 51)
        {
            shopButtonText.text = "Max lvl";
        }

        else
        {
            shopButtonText.text = "Upgrade durability to lvl " + nextLvl.ToString() + " (Cost: " + price.ToString() + " AS)";
        }
    }
}
