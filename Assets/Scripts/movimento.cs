using UnityEngine;

public class movimento : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    private float horizontal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
    }
}
