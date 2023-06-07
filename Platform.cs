using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool IsActive;

    void Update()
    {
        if(IsActive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlatformStop")
        {
            direction *= -1;
        }
        if(other.tag == "Player")
        {
            IsActive = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            IsActive = false;
        }
    }
}
