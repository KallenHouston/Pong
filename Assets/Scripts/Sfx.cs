using UnityEngine;

public class Sfx : MonoBehaviour
{
    public GameObject SFXhit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(SFXhit, transform.position, transform.rotation);
    }
}
