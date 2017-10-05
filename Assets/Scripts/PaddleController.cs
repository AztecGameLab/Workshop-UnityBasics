using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    Camera camera;

    // Use this for initialization
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, transform.position.y, transform.position.z);

    }
}
