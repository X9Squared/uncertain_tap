using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ShowAnimNF : MonoBehaviour
{
    //Setup variables for the rest of the program.
    public Object[] animImport;
    public List<VideoClip> anims = new List<VideoClip>();
    public VideoPlayer viewer;

    public GameObject attached;
    public GameObject canvas;
    public CanvasGroup group;

    //public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        //Set up variables on start of program
        viewer = attached.GetComponent<VideoPlayer>();
        group = canvas.GetComponent<CanvasGroup>();
        //Load all the clips from the Resources folder (talk to me if you want to know more
        //about exactly what the Resources folder is)
        animImport = Resources.LoadAll("VideoAssets", typeof(VideoClip));
        //Load the objects - since Resources.LoadAll outputs only objects - into the List of
        //audioClips (recasting the objects accordingly)
        foreach (Object tmp in animImport)
        {
            VideoClip temp = (VideoClip)tmp;
            anims.Add(temp);
        }
        viewer.source = VideoSource.VideoClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playAnimation(anims[0]);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            playAnimation(anims[1]);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            playAnimation(anims[2]);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            playAnimation(anims[3]);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            playAnimation(anims[4]);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            playAnimation(anims[5]);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            playAnimation(anims[6]);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            playAnimation(anims[7]);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            playAnimation(anims[8]);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            playAnimation(anims[9]);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            playAnimation(anims[10]);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            playAnimation(anims[11]);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            playAnimation(anims[12]);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            playAnimation(anims[13]);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            playAnimation(anims[14]);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            playAnimation(anims[15]);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            playAnimation(anims[16]);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            playAnimation(anims[17]);
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            playAnimation(anims[18]);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            playAnimation(anims[19]);
        }
    }

    void playAnimation(VideoClip v)
    {
        viewer.clip = v;
        viewer.Prepare();
        viewer.Play();
    }
}
