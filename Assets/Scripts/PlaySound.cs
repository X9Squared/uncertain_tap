using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlaySound : MonoBehaviour
{
    public Object[] clipImport;
    public List<AudioClip> clips = new List<AudioClip>();
    public AudioSource player;

    public GameObject attached;

    // Start is called before the first frame update
    void Start()
    {
        player = attached.GetComponent<AudioSource>();
        clipImport = Resources.LoadAll("SoundAssets", typeof(AudioClip));
        foreach (Object tmp in clipImport)
        {
            AudioClip temp = (AudioClip)tmp;
            clips.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
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
        AudioSource tempAudio = attached.AddComponent<AudioSource>();
        tempAudio.clip = clip;
        tempAudio.volume = vol;
        return tempAudio;
    }
}
