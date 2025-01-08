using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    public AudioSource musicSource;
    public AudioSource sfxSource;
    public AudioClip music;
    public AudioClip flapSound;
    public AudioClip hitSound;
    public AudioClip pointSound;
    // private bool isMusicOn = true;
    // private bool isSfxOn = true;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        PlayMusic();
    }

    void PlayMusic()
    {
        musicSource.clip = music;
        musicSource.Play();
    }

    public void PlayFlapSound()
    {
        sfxSource.PlayOneShot(flapSound);
    }

    public void PlayHitSound()
    {
        sfxSource.PlayOneShot(hitSound);
    }

    public void PlayPointSound()
    {
        sfxSource.PlayOneShot(pointSound);
    }

    // public void PauseMusic()
    // {
    //     isMusicOn = !isMusicOn;

    //     if (isMusicOn)
    //     {
    //         musicSource.UnPause();
    //     }
    //     else
    //     {
    //         musicSource.Pause();
    //     }
    // }

    // public void PauseSFX()
    // {
    //     isSfxOn = !isSfxOn;

    //     if (isSfxOn)
    //     {
    //         sfxSource.UnPause();
    //     }
    //     else
    //     {
    //         sfxSource.Pause();
    //     }
    // }
}
