using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTriggers : MonoBehaviour
{
    public PlayableDirector timeline01;
    public PlayableDirector timeline02;
    public PlayableDirector timeline03;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Event1"))
        {
            Debug.Log("Triggered Event 1");
            timeline01.Play();
        }
        if (gameObject.CompareTag("Event2"))
        {
            Debug.Log("Triggered Event 2");
            timeline02.Play();
        }
        if (gameObject.CompareTag("Event3"))
        {
            Debug.Log("Triggered Event 3");
            timeline03.Play();
        }
    }
}
// event trigger scripts must be on the object that the player triggers in the scene (a.k.a. the green cube)
