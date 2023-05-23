using UnityEngine;

public class Sfx : MonoBehaviour
{
    public GameObject sfxHitPrefab;

    private bool hasPlayedSfx = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasPlayedSfx)
        {
            Vector3 contactPoint = collision.GetContact(0).point;
            Instantiate(sfxHitPrefab, contactPoint, Quaternion.identity);
            hasPlayedSfx = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        hasPlayedSfx = false;
    }
}