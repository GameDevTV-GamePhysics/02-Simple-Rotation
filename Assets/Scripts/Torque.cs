using UnityEngine;

public class Torque : MonoBehaviour
{
    public Vector3 torque;
    public float torqueTime;

    private Rigidbody rigidBody;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(torqueTime >= 0f)
        {
            rigidBody.AddTorque(torque);

            torqueTime -= Time.deltaTime;
        }
    }
}
