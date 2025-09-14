using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        foreach (Sound s in sounds)
        {
            if (s.name == name) {
                s.source.Play();
            }
        }
    }

    void Update()
    {
        if (Keyboard.current.fKey.isPressed)
        {
            FindFirstObjectByType<AudioManager>().Play("HiHat");
        }
        if (Keyboard.current.gKey.isPressed)
        {
            FindFirstObjectByType<AudioManager>().Play("MidTom");
        }
        if (Keyboard.current.hKey.isPressed)
        {
            FindFirstObjectByType<AudioManager>().Play("HighTom");
        }
        if (Keyboard.current.jKey.isPressed)
        {
            FindFirstObjectByType<AudioManager>().Play("Cymbal");
        }
        if (Keyboard.current.vKey.isPressed)
        {
            FindFirstObjectByType<AudioManager>().Play("Snare");
        }
        if (Keyboard.current.bKey.isPressed)
        {
            FindFirstObjectByType<AudioManager>().Play("Kick");
        }
        if (Keyboard.current.nKey.isPressed)
        {
            FindFirstObjectByType<AudioManager>().Play("FloorTom");
        }
    }
}
