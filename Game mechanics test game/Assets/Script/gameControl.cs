using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour {

    public GameObject menu;
    public GameObject combatManager;
	// Use this for initialization
	void Start () {
        menu.SetActive(true);
        combatManager.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetButtonUp("Play Turn"))
        {
            menu.SetActive(false);
            combatManager.SetActive(true);
        }
    }
}
