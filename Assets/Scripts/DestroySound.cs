using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySound : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 1);
    }
}
