using UnityEngine;

public class Dog : Animal // INHERITANCE
{

    private float speed = 2f;// ENCAPSULATION”
    public float Speed
    {
        get { return speed; }
    }

    public override void Move()// POLYMORPHISM
    {
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }
}
