using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioClip[] musicSelection = new AudioClip[4];
    public AudioSource source;

    public int thething;
    public int nextsong = 0;

    private void Start()
    {
        thething = musicSelection.Length - 1; 
    }

    public void Update()
    {
        if(gameObject.activeSelf == true)
        {
            if (source.isPlaying == false)
            {
                source.clip = musicSelection[nextsong];
                source.Play();
                switch (nextsong)
                {
                    case 0:
                        nextsong = 1;
                        break;
                    case 1:
                        nextsong = 2;
                        break;
                    case 2:
                        nextsong = 3;
                        break;
                    case 3:
                        nextsong = 0;
                        break;
                }
                Debug.Log(musicSelection[nextsong]);
            }
        }
    }

    public IEnumerator WaitThing()
    {
        if(source.isPlaying == false)
        {
            yield return new WaitForSeconds(8);
            source.clip = musicSelection[Random.Range(0, thething)];
            source.Play();
        }
    }
}
