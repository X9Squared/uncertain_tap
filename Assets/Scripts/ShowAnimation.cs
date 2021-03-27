using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;
using System.Linq;

public class ShowAnimation : MonoBehaviour
{
    //Setup variables for the rest of the program.
    public Object[] animImport;
    public VideoPlayer viewer;
    public string[] anims;
    public GameObject attached;
    public GameObject canvas;
    public CanvasGroup group;
    public FadeAnim fadeScript;
    public string filePath;
   
    //public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        //Set up variables on start of program
        filePath = Application.streamingAssetsPath;
        viewer = attached.GetComponent<VideoPlayer>();
        group = canvas.GetComponent<CanvasGroup>();
        fadeScript = canvas.GetComponent<FadeAnim>();
        anims = Directory.GetFiles(filePath).Where(name => !name.EndsWith(".meta")).ToArray();
        for (int i = 0; i < anims.Length; i++)
        {
            anims[i] = Path.GetFileName((string)anims[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(playAnimation(anims[0], 0.25f));
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(playAnimation(anims[1], 1f));
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(playAnimation(anims[2], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(playAnimation(anims[3], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(playAnimation(anims[4], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(playAnimation(anims[5], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(playAnimation(anims[6], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            StartCoroutine(playAnimation(anims[7], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            StartCoroutine(playAnimation(anims[8], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(playAnimation(anims[9], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(playAnimation(anims[10], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(playAnimation(anims[11], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            StartCoroutine(playAnimation(anims[12], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            StartCoroutine(playAnimation(anims[13], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(playAnimation(anims[14], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(playAnimation(anims[15], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(playAnimation(anims[16], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(playAnimation(anims[17], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            StartCoroutine(playAnimation(anims[18], 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            StartCoroutine(playAnimation(anims[19], 0.5f));
        }
    }

    IEnumerator playAnimation(string s, float delay)
    {
        string url = System.IO.Path.Combine(Application.streamingAssetsPath, s);
        viewer.url = url;
        viewer.Prepare();
        viewer.Play();
        fadeScript.FadeMeIn(group, delay);
        fadeScript.FadeMeOut(group, delay);
        yield return null;
    }
}
