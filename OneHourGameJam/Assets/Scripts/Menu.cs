using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    public GameObject[] panels;
    public int lv;

    //first
    public GameObject msg;
    public Animator fAnim;
    public void TryPlay()
    {
        msg.SetActive(true);
    }
    public void Close() {
        msg.SetActive(false);
    }
    public void Fall() {
        fAnim.SetBool("Fall",true);
    }
//end


    // Use this for initialization
    void Start () {
        msg.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   
}
