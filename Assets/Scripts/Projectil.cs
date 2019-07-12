using UnityEngine;
using System.Collections;

public class Projectil : MonoBehaviour {
    public float speed;

	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Enemic>().kill();
            Destroy(this.gameObject);

        }



    }



	
}
