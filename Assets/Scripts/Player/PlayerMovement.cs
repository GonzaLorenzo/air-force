using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D  myRigidBody;
    public float        Speed;
    public float        LevelEndSpeed;
    public bool         CanMove;
    public bool         CanEndLevel;
    public Vector2      InputVector;
    public KeyCode      MoveRight;
    public KeyCode      MoveLeft;
    public KeyCode      MoveUp;
    public KeyCode      MoveDown;

    private void Awake()
    {
        CanMove = false;
        CanEndLevel = true;
        Speed = 10;
    }
    void Update()
    {
        InputVector.x = Input.GetAxis("Horizontal");
        InputVector.y = Input.GetAxis("Vertical");

        if (CanEndLevel == true)
        {
            transform.position = transform.position + (Vector3.up * LevelEndSpeed * Time.deltaTime);
        }

    }

    private void FixedUpdate()
    {
        if(Mathf.Approximately(InputVector.magnitude, 0f) == false && CanMove == true)
        {
           myRigidBody.MovePosition((Vector2)transform.position + InputVector * (Speed * Time.fixedDeltaTime));
        }
        
    }
    
    public void DestroyPlayer()
    {
        Destroy(this.gameObject);
    }

    public void SpeedBoost()
    {
        Speed = 25;
    }
}
