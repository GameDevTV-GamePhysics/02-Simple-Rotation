using UnityEngine;

[ExecuteInEditMode]
public class ShowStats : MonoBehaviour
{
    private Rigidbody rigidBody;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + " inertia tensor : " + rigidBody.inertiaTensor);
        Debug.Log(gameObject.name + " - Center of Mass : " + rigidBody.worldCenterOfMass);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(rigidBody.worldCenterOfMass, 0.2f);
    }
}