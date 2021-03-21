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
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.clip = clips[0];
            player.Play();
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            player.clip = clips[1];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            player.clip = clips[2];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            player.clip = clips[3];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            player.clip = clips[4];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            player.clip = clips[5];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            player.clip = clips[6];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            player.clip = clips[7];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            player.clip = clips[8];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            player.clip = clips[9];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            player.clip = clips[10];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            player.clip = clips[11];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            player.clip = clips[12];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            player.clip = clips[13];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            player.clip = clips[14];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            player.clip = clips[15];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            player.clip = clips[16];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            player.clip = clips[17];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            player.clip = clips[18];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            player.clip = clips[19];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            player.clip = clips[20];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            player.clip = clips[21];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            player.clip = clips[22];
            player.Play();
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            player.clip = clips[23];
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
