using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public AudioSource source;

    public GameObject[] panels;
    public bool op;
    public bool play;

    //first
    public GameObject msg;
    public GameObject options;
    public GameObject btn;
 

  
    public void TryPlay()
    {
        if (play) {
            panels[2].SetActive(true);
        }
        else
        {
            msg.SetActive(true);
        }
    }
    public void Close() {
        msg.SetActive(false);
    }
    public void Fall() {
       Destroy(btn);
        crack.SetActive(true);
        panels[1].SetActive(true);
    }
    public void Options() {
        if (!op)
        {
            options.SetActive(true);
            rOptions.SetActive(false);
        }
        else {
            options.SetActive(false);
            rOptions.SetActive(true);
        }
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
    public GameObject rOptions;


    public void checkKey() {
        if (keyd) {
            Destroy(key);
            
            op = true;
            Options();
        }
    }
    //
    //quatro
    public Slider slide;
    public Slider sSlide;
    public GameObject inp;
    public GameObject message;

    public void ROClose()
    {
        rOptions.SetActive(false);
    }
    //

    public void CloseApp() {
        Application.Quit();
    }


    // Use this for initialization
    void Start () {
        crack.SetActive(false);
        key.SetActive(false);
        msg.SetActive(false);
        options.SetActive(false);
        panels[1].SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
            Color color = inp.GetComponent<Image>().color;
            
            color.a = slide.value;
            inp.GetComponent<Image>().color = color;
        
            message.SetActive(slide.value > 0.95f);

         source.volume = sSlide.value;
        play = (inp.GetComponent<InputField>().text=="2725");
        
    }
   
}
