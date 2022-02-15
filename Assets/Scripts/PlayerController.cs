using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= -10)
        {
            FadeManager.Instance.LoadLevel("GameOver", 0.5f);
        }

        if (Input.GetKey("up"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, power);
            //Debug.Log("Go");
        }

        if (Input.GetKey("down"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, -power);
            //Debug.Log("Down");
        }

        if (Input.GetKey("left"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(-power, 0, 0);
            //Debug.Log("Left");
        }

        if (Input.GetKey("right"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(power, 0, 0);
            //Debug.Log("Right");
        }
    }
}
