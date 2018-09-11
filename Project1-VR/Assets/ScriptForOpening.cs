using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForOpening : MonoBehaviour {

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "player")
        {
            anim.Play("openGaskett");
        }
        Destroy(other.gameObject);
    }
}
