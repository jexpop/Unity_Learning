using UnityEngine;

public class Farm : Animal // INHERITANCE
{

    private float speed = 1f;

    public override void Move()// POLYMORPHISM
    {
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }
}
