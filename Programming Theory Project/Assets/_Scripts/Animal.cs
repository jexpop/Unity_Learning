using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    public virtual void Move()// POLYMORPHISM & ABSTRACTION
    {
        transform.Translate(Vector3.forward * 0 * Time.fixedDeltaTime);
    }

}
