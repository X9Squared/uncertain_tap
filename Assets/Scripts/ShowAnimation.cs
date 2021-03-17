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
    public GameObject canvas;
    public CanvasGroup group;
    public FadeAnim fadeScript;
   
    //public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        //Set up variables on start of program
        viewer = attached.GetComponent<VideoPlayer>();
        group = canvas.GetComponent<CanvasGroup>();
        fadeScript = canvas.GetComponent<FadeAnim>();
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
            StartCoroutine(playAnimation(anims[0], 0.25f));
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(playAnimation(anims[1], 1f));
        }
    }

    IEnumerator playAnimation(VideoClip v, float delay)
    {
        viewer.clip = v;
        viewer.Prepare();
        viewer.Play();
        fadeScript.FadeMeIn(group, delay);
        fadeScript.FadeMeOut(group, delay);
        yield return null;
    }
}
