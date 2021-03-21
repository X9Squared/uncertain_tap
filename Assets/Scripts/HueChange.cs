using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HueChange : MonoBehaviour
{
    public Image panel;
    public GameObject attached;
    // Start is called before the first frame update
    void Start()
    {
        panel = attached.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            panel.color = Color.Lerp(panel.color, newColor(), Mathf.PingPong(Time.time, 1));
        }
    }

    Color newColor()
    {
        return new Color(Random.value, Random.value, Random.value, 0.2f);
    }
}
