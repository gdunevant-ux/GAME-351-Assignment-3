using UnityEngine;

public class GunfightTrigger : MonoBehaviour
{
    private MusicManager musicManager;
    private AudioSource gunshotSource;

    void Start()
    {
        musicManager = FindObjectOfType<MusicManager>();

        AudioSource[] sounds = GetComponents<AudioSource>();
        gunshotSource = sounds[1];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            musicManager.PlayGunfight();
            gunshotSource.Play();
        }
    }
}