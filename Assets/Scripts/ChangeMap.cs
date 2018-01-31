using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeMap : MonoBehaviour {

    public SpriteRenderer Drawing, Satalite;

    private bool isVisible = false;

    void Start(){
        Drawing.GetComponent<SpriteRenderer>().enabled = true;
        Satalite.GetComponent<SpriteRenderer>().enabled = false;        
    }

    public void ButtonClick () {
        isVisible = !isVisible;
        Change();
	}

    void Change(){

        if (isVisible)
        {
            Drawing.GetComponent<SpriteRenderer>().enabled = false;
            Satalite.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (!isVisible)
        {
            Drawing.GetComponent<SpriteRenderer>().enabled = true;
            Satalite.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
