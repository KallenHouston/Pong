using UnityEngine;

public class BotPaddle : Paddle
{
    public Rigidbody2D ballz;
    
    private void FixedUpdate()
    {
        if (this.ballz.velocity.x > 0.0f)
        {
            if (this.ballz.position.y > this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.up * this.speed);
            } else if (this.ballz.position.y < this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                _rigidBody.AddForce(Vector2.down * this.speed);
            } else if(this.transform.position.y < 0.0f)
            {
                _rigidBody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
