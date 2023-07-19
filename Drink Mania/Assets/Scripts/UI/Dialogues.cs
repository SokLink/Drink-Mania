using System.Collections;
using TMPro;
using UnityEngine;

public class Dialogues : MonoBehaviour
{
    [SerializeField] private AlcoholScoreEncreaser alcoholScoreEncreaser;
    [SerializeField] private AnimationController animationController;
    [SerializeField] private AudioManager audioManager;

    [SerializeField] private TextMeshProUGUI dialogueText;

    private string[] _dworfDialogues = new string[5]
    {
        "Hello wimp! Ready to lose?",
        "Rock and Stone!",
        "I hate elves, but even more I hate losing",
        "Oh... it's a pity my six brothers aren't here",
        "For the... Aragorn..."
    };

    private string[] _cowboyDialogues = new string[5]
    {
        "Howdy partner!",
        "If you want to drink - drink!",
        "Hahaha, you're weaker than a coyote!",
        "I'm the toughest drinker in the Wild West!",
        "Oh, damn it..."
    };

    private string[] _piratDialogues = new string[5]
    {
        "Ahaha, this land rat has already managed to fill the hold of two weaklings",
        "Squid guts! I will send you to the bottom of the sea!",
        "Once I drank my whole team in a tavern to the mayor of a provincial town",
        "You would be a great cabin boy on my ship",
        "Fair wind to you, I throw out a white flag"
    };

    private string[] _mexicanDialogues = new string[5]
    {
        "Buenos dias!",
        "Never give up, amigo!",
        "When you only have una vida it becomes invaluable",
        "Appreciate la familia, I didn't appreciate and perdi",
        "Oh, santa buritos..."
    };

    private string[] _russianDialogues = new string[5]
    {
        "Nu che maloy, davai poveselimsya!",
        "Ty che ah*el samogon zakusyvat!?",
        "Pomnyu ya kak to plaval v bochke iz-pod seledki vo vremya voiny",
        "Muzhik, a ty ne ploh, u tebya baki pryam dlya alkashki est kak ya vizhu",
        "Slovo za slovo, h*em po stolu!"
    };

    public void PlayDialogues(int currentLvl)
    {
        switch(currentLvl)
        {
            case 3:
                SwapText(_dworfDialogues[1]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Dworf");
                break;

            case 6:
                SwapText(_dworfDialogues[2]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Dworf");
                break;

            case 8:
                SwapText(_dworfDialogues[3]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Dworf");
                break;



            case 11:
                StartCoroutine(SwapDialoguesWhenSwapEnemyes("Dworf", "Cowboy", _dworfDialogues[4], _cowboyDialogues[0]));
                break;



            case 13:
                SwapText(_cowboyDialogues[1]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Cowboy");
                break;

            case 16:
                SwapText(_cowboyDialogues[2]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Cowboy");
                break;

            case 18:
                SwapText(_cowboyDialogues[3]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Cowboy");
                break;



            case 21:
                StartCoroutine(SwapDialoguesWhenSwapEnemyes("Cowboy", "Pirat", _cowboyDialogues[4], _piratDialogues[0]));
                break;



            case 23:
                SwapText(_piratDialogues[1]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Pirat");
                break;

            case 26:
                SwapText(_piratDialogues[2]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Pirat");
                break;

            case 28:
                SwapText(_piratDialogues[3]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Pirat");
                break;



            case 31:
                StartCoroutine(SwapDialoguesWhenSwapEnemyes("Pirat", "Mexican", _piratDialogues[4], _mexicanDialogues[0]));
                break;



            case 33:
                SwapText(_mexicanDialogues[1]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Mexican");
                break;

            case 36:
                SwapText(_mexicanDialogues[2]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Mexican");
                break;

            case 38:
                SwapText(_mexicanDialogues[3]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Mexican");
                break;



            case 41:
                StartCoroutine(SwapDialoguesWhenSwapEnemyes("Mexican", "Russian", _mexicanDialogues[4], _russianDialogues[0]));
                break;



            case 43:
                SwapText(_russianDialogues[1]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Russian");
                break;

            case 46:
                SwapText(_russianDialogues[2]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Russian");
                break;

            case 48:
                SwapText(_russianDialogues[3]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Russian");
                break;

            case 50:
                SwapText(_russianDialogues[4]);
                animationController.SwapAnimation("Swing", false);
                audioManager.VoicePlay("Russian");
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

    private IEnumerator SwapDialoguesWhenSwapEnemyes(string firstVoiceOwner, string secondVoiceOwner, string fristDialogue, string secondDialogue)
    {
        dialogueText.text  = fristDialogue;
        audioManager.VoicePlay(firstVoiceOwner);

        yield return new WaitForSeconds(3f);

        SwapText(secondDialogue);
        audioManager.VoicePlay(secondVoiceOwner);
    }

    public void PlayOnButtonStart(bool isFromStart)
    {
        SwapText(_dworfDialogues[0]);
        animationController.SwapAnimation("Swing", isFromStart);
        audioManager.VoicePlay("Dworf");
    }
}
