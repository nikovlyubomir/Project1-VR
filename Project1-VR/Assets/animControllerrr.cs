using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animControllerrr : MonoBehaviour {

    
    public string loadScene;
    //public GameObject cube;
    public bool hasAnimation;
    public Animator anim;
    public string animationTriggerName;

    // Use this for initialization
    void Start()
    {
        if (!hasAnimation) { anim = null;  animationTriggerName = ""; }
        //cube = gameObject.GetComponent<GameObject>();
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("W hit the box");
           if (hasAnimation)
            { anim.SetTrigger(animationTriggerName); }

            Invoke("ChangeLevel", 3.0f);
            
            // logic for later: whenever the player open scene2 and answer the question
            // he will be back in scene1 and the door for the next room will be automatically
            // opened.

        }
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(loadScene);
    }
}
