using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlaySound : MonoBehaviour
{
    //Setup variables for the rest of the program.
    public Object[] clipImport;
    public List<AudioClip> clips = new List<AudioClip>();
    public AudioSource player;

    public GameObject attached;

    // Start is called before the first frame update
    void Start()
    {
        //Set up the audiosource to be able to play the clips
        player = attached.GetComponent<AudioSource>();
        //Load all the clips from the Resources folder (talk to me if you want to know more
        //about exactly what the Resources folder is)
        clipImport = Resources.LoadAll("SoundAssets", typeof(AudioClip));
        //Load the objects - since Resources.LoadAll outputs only objects - into the List of
        //audioClips (recasting the objects accordingly)
        foreach (Object tmp in clipImport)
        {
            AudioClip temp = (AudioClip)tmp;
            clips.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Check GetKeyDown to play something when certain keyboard keys are pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            player.clip = clips[0];
            player.Play();
        } else if (Input.GetKeyDown(KeyCode.J))
        {
            player.clip = clips[1];
            player.Play();
        }
    }

    public AudioSource audioConfig(AudioClip clip, float vol)
    {
        //Assign the clip to the AudioPlayer to be played
        AudioSource tempAudio = attached.AddComponent<AudioSource>();
        tempAudio.clip = clip;
        tempAudio.volume = vol;
        return tempAudio;
    }
}
