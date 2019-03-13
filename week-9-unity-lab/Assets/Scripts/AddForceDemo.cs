using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceDemo : MonoBehaviour
{
    // Start is called before the first frame update
	public Vector3 pushDirecion = new Vector3(0,0,1);
		public float pushForce = 500;
		public void OnMouseOver()
		{
			GetComponent<Rigidbody>().AddForce(pushDirecion * pushForce);
		}
        
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
