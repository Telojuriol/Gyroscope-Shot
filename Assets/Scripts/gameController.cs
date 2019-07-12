using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

    public float time;
    public float percentageTime;
    public GameObject Enemic1;

    private float internTime;

	void Start () {

    }
	

	void Update () {
        internTime += Time.deltaTime;
        if(internTime >= time)
        {
            time = time * percentageTime;
            internTime = 0;
            Instantiate(Enemic1, RandomCircle() ,Enemic1.transform.rotation);
            
        }
        
    }

    Vector3 RandomCircle()
    {
        float radius = Random.Range(20,50);
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x =radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.z =radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.y = 2.22f;
        return pos;
    }
}
