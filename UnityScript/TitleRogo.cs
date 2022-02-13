using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleRogo : MonoBehaviour
{
    Rigidbody rigidbody;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(new Vector3(0, -1, 0) * speed * Time.deltaTime);
    }
}
