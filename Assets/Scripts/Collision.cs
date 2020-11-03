using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    int score = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider c)
    {

        Debug.Log("trigger");

        if (c.tag.Equals("coin"))
        {
            score++;

            Destroy(c.transform.gameObject);

        }


    }
}
