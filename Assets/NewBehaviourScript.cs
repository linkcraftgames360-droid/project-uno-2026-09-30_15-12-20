using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviorScript : MonoBehaviour
{
    public float speed = 4;
    // Start is called before the first frame update
    void update()
    {
        if(Input.GetKey(KeyCode.W))
         transform.Translate(transform.up * speed * Time.deltaTime);
    }
}

