using UnityEngine;

public class Dialogues : MonoBehaviour
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;

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
                Debug.Log(_dworfDialogues[0]);
                break;

            case 4:
                Debug.Log(_dworfDialogues[1]);
                break;

            case 5:
                Debug.Log(_dworfDialogues[2]);
                break;

            case 7:
                Debug.Log(_dworfDialogues[3]);
                break;

            case 9:
                Debug.Log(_dworfDialogues[4]);
                break;



            case 12:
                Debug.Log(_cowboyDialogues[0]);
                break;

            case 14:
                Debug.Log(_cowboyDialogues[1]);
                break;

            case 15:
                Debug.Log(_cowboyDialogues[2]);
                break;

            case 17:
                Debug.Log(_cowboyDialogues[3]);
                break;

            case 19:
                Debug.Log(_cowboyDialogues[4]);
                break;



            case 22:
                Debug.Log(_piratDialogues[0]);
                break;

            case 24:
                Debug.Log(_piratDialogues[1]);
                break;

            case 25:
                Debug.Log(_piratDialogues[2]);
                break;

            case 27:
                Debug.Log(_piratDialogues[3]);
                break;

            case 29:
                Debug.Log(_piratDialogues[4]);
                break;



            case 32:
                Debug.Log(_mexicanDialogues[0]);
                break;

            case 34:
                Debug.Log(_mexicanDialogues[1]);
                break;

            case 35:
                Debug.Log(_mexicanDialogues[2]);
                break;

            case 37:
                Debug.Log(_mexicanDialogues[3]);
                break;

            case 39:
                Debug.Log(_mexicanDialogues[4]);
                break;



            case 42:
                Debug.Log(_russianDialogues[0]);
                break;

            case 44:
                Debug.Log(_russianDialogues[1]);
                break;

            case 45:
                Debug.Log(_russianDialogues[2]);
                break;

            case 47:
                Debug.Log(_russianDialogues[3]);
                break;

            case 49:
                Debug.Log(_russianDialogues[4]);
                break;
        }
    }
}
