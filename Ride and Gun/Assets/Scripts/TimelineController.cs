using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    private PlayableDirector playableDirector;
    private bool isCollision = false;

    // Start is called before the first frame update
    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollision)
        {
            playableDirector.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isCollision = true;
    }
}
