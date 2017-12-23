using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    public GameObject[] panels;
    

    //first
    public GameObject msg;
    public GameObject options;
    public GameObject btn;


  
    public void TryPlay()
    {
        msg.SetActive(true);
    }
    public void Close() {
        msg.SetActive(false);
    }
    public void Fall() {
       Destroy(btn);
        panels[1].SetActive(true);
    }
    public void Options() {
        options.SetActive(true);
    }
    public void OOClose()
    {
        options.SetActive(false);
    }
    
    //end
    //dois
    public GameObject key;
    public bool keyd;
    public GameObject crack;

    public void Crack() {
        Destroy(crack);
        keyd = true;
        key.SetActive(true);
    }
    //
    //tres

    public void checkKey() {
        if (keyd) {
            Destroy(key);
            panels[2].SetActive(true);
        }
    }    
     //

    public void CloseApp() {
        Application.Quit();
    }


    // Use this for initialization
    void Start () {
        key.SetActive(false);
        msg.SetActive(false);
        options.SetActive(false);
        panels[1].SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   
}
