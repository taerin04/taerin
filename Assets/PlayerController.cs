using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    float horizontal;
    float vertical;
    public float speed=10;
    // 로딩
    void Awake()
    { rigidbody = GetComponent<Rigidbody>();
   


    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.velocity = new Vector3(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3(horizontal, rigidbody.velocity.y, vertical);
    }
}
