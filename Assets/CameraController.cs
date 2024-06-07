using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 deltaPosition;
    public Vector3 deltaRotation;
    public GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        deltaPosition = new Vector3(0, 7, -10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObject.transform.position + deltaPosition;
    }
}
