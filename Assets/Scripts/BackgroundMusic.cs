using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic music;
    private void Awake()
    {
        if (music == null)
        {
            music = this;
            DontDestroyOnLoad(music);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
