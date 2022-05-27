using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCPlayerController : MonoBehaviour
{

    public Rigidbody2D PCCarrb;
    public Rigidbody2D backwheel;
    public Rigidbody2D frontwheel;
    public float speed;
    public float carTorque;
    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backwheel.AddTorque(-speed * Time.deltaTime);
        frontwheel.AddTorque(-speed * Time.deltaTime);
        PCCarrb.AddTorque(-carTorque * Time.deltaTime);
    }
}
