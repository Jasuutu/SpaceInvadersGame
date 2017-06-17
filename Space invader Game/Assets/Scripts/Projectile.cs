using UnityEngine;

public class Projectile : MonoBehaviour {

    public float moveSpeed = 10f; 
	// Use this for initialization
	void Awake ()
    {
        // kill me, just not right this second...
        Destroy(gameObject, 2f);	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // just movin' on up :)
        transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, 0f);
	} 
}
