using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;
    public int scoreVal = 0;
    public TextMeshProUGUI scoreBox;
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }


        transform.position = new Vector3(transform.position.x,
                             Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag =="Projectile")
        {
            if (collision.GetComponent<ProjectileMove>() != null)
        {
            scoreVal += collision.GetComponent<ProjectileMove>().points;
            scoreBox.text = "score:" +scoreVal;
            Destroy(collision.gameObject);

        }
        
        
        }
    }
}

