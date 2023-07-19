using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip mainMusic;
    [SerializeField] private AudioClip buttonAudio;
    [SerializeField] private AudioClip DrinkSound;
    [SerializeField] private AudioClip enviromentSound;
    [SerializeField] private AudioClip lvlUpSound;
    [SerializeField] private AudioClip fallSound;

    [SerializeField] private AudioClip DworfVoice;
    [SerializeField] private AudioClip CowboyVoice;
    [SerializeField] private AudioClip PiratVoice;
    [SerializeField] private AudioClip MexicanVoice;
    [SerializeField] private AudioClip RussianVoice;

    [SerializeField] private AudioSource cameraAudioSource;
    [SerializeField] private AudioSource menuAudioSource;
    [SerializeField] private AudioSource playerAudioSource;
    [SerializeField] private AudioSource tableAudioSource;
    [SerializeField] private AudioSource enemyAudioSource;
    [SerializeField] private AudioSource GameControllerAS;
    [SerializeField] private AudioSource AntogonistSpriteAS;

    private void Awake()
    {
        playerAudioSource.clip = DrinkSound;
        playerAudioSource.Play();
    }

    public void SwapToMainMusic()
    {
        cameraAudioSource.clip = mainMusic;
        cameraAudioSource.Play();
    }

    public void ButtonAudio()
    {
        menuAudioSource.clip = buttonAudio;
        menuAudioSource.Play();
    }

    public void PlayDrinkSound(bool playOrNot)
    {
        if(playOrNot)
        {
            playerAudioSource.volume = 0.35f;
        }
        else
        {
            playerAudioSource.volume = 0;
        }
    }

    public void EnviromentalStartOnStart()
    {
        tableAudioSource.clip = enviromentSound;
        tableAudioSource.Play();
    }

    public void VoicePlay(string enemyName)
    {
        switch (enemyName)
        {
            case "Dworf":
                enemyAudioSource.clip = DworfVoice;
                enemyAudioSource.Play();
                break;

            case "Cowboy":
                enemyAudioSource.clip = CowboyVoice;
                enemyAudioSource.Play();
                break;

            case "Pirat":
                enemyAudioSource.clip = PiratVoice;
                enemyAudioSource.Play();
                break;

            case "Mexican":
                enemyAudioSource.clip = MexicanVoice;
                enemyAudioSource.Play();
                break;

            case "Russian":
                enemyAudioSource.clip = RussianVoice;
                enemyAudioSource.Play();
                break;
        }
    }

    public void LvlUpSoundPlay()
    {
        GameControllerAS.clip = lvlUpSound;
        GameControllerAS.Play();
    }

    public void FallSound()
    {
        AntogonistSpriteAS.clip = fallSound;
        AntogonistSpriteAS.Play();
    }
}
