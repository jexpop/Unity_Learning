using UnityEngine;

public class Forest : Animal // INHERITANCE
{

    private float speed = 3f;

    public override void Move()// POLYMORPHISM
    {
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }
}
