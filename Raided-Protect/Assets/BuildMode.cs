using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMode : MonoBehaviour
{
    public GameObject CameraHolder;
    public float rotationSpeed = 25f;
    public float rotation  = 75f;

    public GameObject mainManager;
    MainManager MM;
    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            rotation += Time.deltaTime * rotationSpeed;
            transform.rotation = Quaternion.Euler(45, rotation, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotation += Time.deltaTime * -rotationSpeed;
            transform.rotation = Quaternion.Euler(45, rotation, 0);
        }
    }
}
