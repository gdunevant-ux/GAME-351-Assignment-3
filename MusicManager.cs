using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
    private AudioSource defaultMusic;
    private AudioSource suspenseMusic;
    private AudioSource gunfightMusic;

    private AudioSource currentMusic;

    void Start()
    {
        AudioSource[] music = GetComponents<AudioSource>();

        defaultMusic = music[0];
        suspenseMusic = music[1];
        gunfightMusic = music[2];

        // Keep all music at a reasonable volume
        defaultMusic.volume = 0.25f;
        suspenseMusic.volume = 0.25f;
        gunfightMusic.volume = 0.25f;

        suspenseMusic.Stop();
        gunfightMusic.Stop();

        currentMusic = defaultMusic;

        if (!defaultMusic.isPlaying)
            defaultMusic.Play();
    }

    public void PlayDefault()
    {
        ChangeMusic(defaultMusic);
    }

    public void PlaySuspense()
    {
        ChangeMusic(suspenseMusic);
    }

    public void PlayGunfight()
    {
        ChangeMusic(gunfightMusic);
    }

    void ChangeMusic(AudioSource newMusic)
    {
        if (currentMusic == newMusic)
            return;

        StopAllCoroutines();
        StartCoroutine(FadeMusic(currentMusic, newMusic));
    }

    IEnumerator FadeMusic(AudioSource oldMusic, AudioSource newMusic)
    {
        float time = 1.5f;

        newMusic.volume = 0;
        newMusic.Play();

        for (float t = 0; t < time; t += Time.deltaTime)
        {
            oldMusic.volume = 0.25f * (1 - (t / time));
            newMusic.volume = 0.25f * (t / time);

            yield return null;
        }

        oldMusic.Stop();

        oldMusic.volume = 0.25f;
        newMusic.volume = 0.25f;

        currentMusic = newMusic;
    }
}