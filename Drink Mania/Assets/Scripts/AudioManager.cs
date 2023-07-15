using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip mainMusic;

    [SerializeField] private AudioSource cameraAudioSource;

    public void SwapToMainMusic()
    {
        cameraAudioSource.clip = mainMusic;
        cameraAudioSource.Play();
    }
}
