using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMessage : MonoBehaviour {
    public Text winText;
	// Use this for initialization
	void Start () {
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            print("BLUE!!");
            winText.text = "Blue Wins!!";
        }
        else
        {
            winText.text = "Green Wins!!";
        }

    }

}
