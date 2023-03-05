
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float forwardforce = 300f;
    public float sidwayforce = 50f;
    

    public void Update()
    {
        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sidwayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sidwayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rigidbody.AddForce(0, 0, forwardforce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rigidbody.AddForce(0, 0, -forwardforce * Time.deltaTime, ForceMode.VelocityChange);
        }
        

    }
}
