using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followSmoothRotation : MonoBehaviour
{
    public GameObject target;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, target.transform.rotation, rotationSpeed * Time.deltaTime);
        }
    }
}
