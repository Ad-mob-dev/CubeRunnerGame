using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip collectSound;
    public AudioClip crashSound;

    private void OnDisable()
    {
      CollisionController.GameAudio -= PlaySound;
    }

    private void OnEnable()
    {
        CollisionController.GameAudio += PlaySound;
    }

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
    }


    void PlaySound(bool isObstacle, bool isCollectable)
    {
        if (isCollectable)
        {
            audioSource.clip = collectSound;
        }
        else if (isObstacle)
        {
            audioSource.clip = crashSound;
        }
        audioSource.Play();
    }
}
