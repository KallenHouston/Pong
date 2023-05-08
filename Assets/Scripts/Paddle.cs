using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidBody;
    public float speed = 15.0f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public void ResetPos()
    {
        _rigidBody.position = new Vector2(_rigidBody.position.x, 0.0f);
        _rigidBody.velocity = Vector2.zero;
    }
}
