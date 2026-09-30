using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
  public float speed =6;
  public int points = 100;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.right * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "player") {
        Destroy(gameObject);
        }
    }
}

