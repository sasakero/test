using UnityEngine;
using System.Collections;

public class GravityContller : MonoBehaviour {

    const float GRAVITY = 9.81f;

    public float gravityScale = 1.0f;
	
	// Update is called once per frame
	void Update () {
        Vector3 vector = new Vector3();

        if (Application.isEditor){

            vector.x = Input.GetAxis("Horizontal");
            vector.z = Input.GetAxis("Vertical");

            if (Input.GetKey("space"))
            {
                vector.y = 1.0f;
            }
            else
            {
                vector.y = -1.0f;
            }

            Physics.gravity = GRAVITY * vector.normalized * gravityScale;
        }else{
            //加速度センサ対応
            vector.x = Input.acceleration.x;
            vector.z = Input.acceleration.y;
            vector.y = Input.acceleration.z;
        }
	}
}
