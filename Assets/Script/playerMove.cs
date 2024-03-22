using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    [SerializeField] private Animator avtar;
    [SerializeField] private Rigidbody2D rb;
  //  [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer spriterender;
    private bool isGround=false;
    private void Update()
    {
      //  if (avtar != null &&Input.GetKeyDown(KeyCode.RightArrow))
      //  {
           
       // }

        //for run
        if((Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.LeftArrow))|| (Input.GetKey(KeyCode.A))|| (Input.GetKey(KeyCode.D))))
        {
            avtar.SetBool("isRun",true);
           
        }
        else
        {
            avtar.SetBool("isRun", false);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            spriterender.flipX = false;
          //  spriterender.flipY = true;
            transform.position = new Vector2(transform.position.x + 0.09f, transform.position.y);

        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            spriterender.flipX = true;
            spriterender.flipY = false;
            transform.position = new Vector2(transform.position.x -0.09f, transform.position.y);

        }

        //for Jump

        if((Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.W)) && isGround)
        {
            avtar.SetBool("isJump",true);
        }
        else
        {
            avtar.SetBool("isJump",false);
        }
        if((Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.W) ) && isGround)
        {
            rb.velocity=new Vector2(0.0f,5f);
        }

    }
    private void IsRunning()
    {
        if(avtar != null)
        {
            rb.velocity += new Vector2(transform.position.x+0.1f,0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            Debug.Log("collide with body ");
        }
       
    }
}
