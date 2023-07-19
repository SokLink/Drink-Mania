using System.Collections;
using TMPro;
using UnityEngine;

public class Dialogues : MonoBehaviour
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;
    [SerializeField] private AnimationController animationController;

    [SerializeField] private TextMeshProUGUI dialogueText;

    private string[] _dworfDialogues = new string[5]
    {
        "d1",
        "d2",
        "d3",
        "d4",
        "d5"
    };

    private string[] _cowboyDialogues = new string[5]
    {
        "c1",
        "c2",
        "c3",
        "c4",
        "c5"
    };

    private string[] _piratDialogues = new string[5]
    {
        "p1",
        "p2",
        "p3",
        "p4",
        "p5"
    };

    private string[] _mexicanDialogues = new string[5]
    {
        "m1",
        "m2",
        "m3",
        "m4",
        "m5"
    };

    private string[] _russianDialogues = new string[5]
    {
        "r1",
        "r2",
        "r3",
        "r4",
        "r5"
    };

    public void PlayDialogues(int currentLvl)
    {
        switch(currentLvl)
        {
            case 2:
                SwapText(_dworfDialogues[0]);
                animationController.SwapAnimation("Swing");
                break;

            case 4:
                SwapText(_dworfDialogues[1]);
                animationController.SwapAnimation("Swing");
                break;

            case 5:
                SwapText(_dworfDialogues[2]);
                animationController.SwapAnimation("Swing");
                break;

            case 7:
                SwapText(_dworfDialogues[3]);
                animationController.SwapAnimation("Swing");
                break;

            case 9:
                SwapText(_dworfDialogues[4]);
                animationController.SwapAnimation("Swing");
                break;



            case 12:
                SwapText(_cowboyDialogues[0]);
                animationController.SwapAnimation("Swing");
                break;

            case 14:
                SwapText(_cowboyDialogues[1]);
                animationController.SwapAnimation("Swing");
                break;

            case 15:
                SwapText(_cowboyDialogues[2]);
                animationController.SwapAnimation("Swing");
                break;

            case 17:
                SwapText(_cowboyDialogues[3]);
                animationController.SwapAnimation("Swing");
                break;

            case 19:
                SwapText(_cowboyDialogues[4]);
                animationController.SwapAnimation("Swing");
                break;



            case 22:
                SwapText(_piratDialogues[0]);
                animationController.SwapAnimation("Swing");
                break;

            case 24:
                SwapText(_piratDialogues[1]);
                animationController.SwapAnimation("Swing");
                break;

            case 25:
                SwapText(_piratDialogues[2]);
                animationController.SwapAnimation("Swing");
                break;

            case 27:
                SwapText(_piratDialogues[3]);
                animationController.SwapAnimation("Swing");
                break;

            case 29:
                SwapText(_piratDialogues[4]);
                animationController.SwapAnimation("Swing");
                break;



            case 32:
                SwapText(_mexicanDialogues[0]);
                animationController.SwapAnimation("Swing");
                break;

            case 34:
                SwapText(_mexicanDialogues[1]);
                animationController.SwapAnimation("Swing");
                break;

            case 35:
                SwapText(_mexicanDialogues[2]);
                animationController.SwapAnimation("Swing");
                break;

            case 37:
                SwapText(_mexicanDialogues[3]);
                animationController.SwapAnimation("Swing");
                break;

            case 39:
                SwapText(_mexicanDialogues[4]);
                animationController.SwapAnimation("Swing");
                break;



            case 42:
                SwapText(_russianDialogues[0]);
                animationController.SwapAnimation("Swing");
                break;

            case 44:
                SwapText(_russianDialogues[1]);
                animationController.SwapAnimation("Swing");
                break;

            case 45:
                SwapText(_russianDialogues[2]);
                animationController.SwapAnimation("Swing");
                break;

            case 47:
                SwapText(_russianDialogues[3]);
                animationController.SwapAnimation("Swing");
                break;

            case 49:
                SwapText(_russianDialogues[4]);
                animationController.SwapAnimation("Swing");
                break;
        }
    }

    private void SwapText(string text)
    {
        dialogueText.text = text;

        StartCoroutine(SwapTextReverse());
    }

    private IEnumerator SwapTextReverse()
    {
        yield return new WaitForSeconds(5f);

        dialogueText.text = "...";
    }
}
