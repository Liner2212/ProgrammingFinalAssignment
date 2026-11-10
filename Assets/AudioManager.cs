using UnityEngine;
using Unity.Collections;






public class AudioManager : MonoBehaviour
{
    //for where the audio conmes from, im making this script to manage all the audio in my scene and public audioclip to fill in what my background music will be and for checkpoints
    [SerializeField] AudioSource musicSource; //store to disk
    [SerializeField] AudioSource SFXSource;

    public AudioClip Background;
    public AudioClip Checkpoint;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();

    }


}
