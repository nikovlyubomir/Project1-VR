using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour {
    public Animation chestOpen;
    public GameObject treasureChest;



    void Start () {
        Animation chestOpen = GetComponent<Animation>();
        GameObject treasureChest = GetComponent<GameObject>();
    }
	
	
	void Update () {
		
	}
}
