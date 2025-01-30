using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        private Rigidbody rb;

        private void Start(){
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.right * 500);
        }

        void OnCollisionEnter(Collision collision){
            Debug.log("Collision detected with " + collision.gameObject.name);
        }
    }
}
