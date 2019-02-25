using UnityEngine;

public class player_movemen : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public Vector3 jump;
    public float jumpForce = 5.0f;
    public float sidewaysforce = 100f;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>
        jump = new Vector3(0.0f, 3.0f, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 0);

        if (Input.GetKey("d"))
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey("a"))
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        /*if (Input.GetKey("s") && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }*/

        if (Input.GetKey("w"))
            rb.AddForce(0, 0, -sidewaysforce * Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey("s"))
            rb.AddForce(0, 0, sidewaysforce * Time.deltaTime, ForceMode.VelocityChange);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
}
