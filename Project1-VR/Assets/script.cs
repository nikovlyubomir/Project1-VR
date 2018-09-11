using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{

    public Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();

    }
    void Playmusic()
    {
        if (Input.GetKeyDown("W"))
        {
            anim.Play("open");
        }

    }
}
