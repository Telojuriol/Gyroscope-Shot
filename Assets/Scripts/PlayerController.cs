using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    GameObject projectil;
	// Use this for initialization
	void Start () {
        projectil = Resources.Load("projectil") as GameObject;
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    public void dispara()
    {
        GameObject p1 = Instantiate(projectil, transform.position, Quaternion.identity) as GameObject;
        p1.transform.LookAt(transform.position + transform.forward);


    }



}
