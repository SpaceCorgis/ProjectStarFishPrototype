using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

    //added stuff from VS
	// Use this for initialization

    private Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Hit Button");
            anim.SetTrigger("Pushed");
        }
        if (Input.GetButtonUp("Jump"))
        {
            anim.SetTrigger("Pushed");
        }
	
	}
}
