using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ShowAnimation : MonoBehaviour
{
    //Setup variables for the rest of the program.
    public Object[] animImport;
    public List<VideoClip> anims = new List<VideoClip>();
    public VideoPlayer viewer;

    public GameObject attached;
    //public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        //Set up the videosource to be able to play the clips
        viewer = attached.GetComponent<VideoPlayer>();
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
        if (Input.GetKeyDown(KeyCode.M))
        {
            viewer.clip = anims[0];
            viewer.Prepare();
            viewer.Play();
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            viewer.clip = anims[1];
            viewer.Prepare();
            viewer.Play();
        }
    }

}
