using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlay : MonoBehaviour {

    public Animation ani;
    // Use this for initialization
    void Start()
    {
        ani.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            ani.Play("openGaskett");
        }
    }
}
