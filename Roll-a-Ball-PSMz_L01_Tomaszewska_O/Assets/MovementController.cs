using UnityEngine;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{
    public int score = 0;

    private Rigidbody rb;
 
    public
        float thrust = 5;

    public void CollectScore()
    {
        score += 1;
        Debug.Log("Zdobyles punkt! Liczba punktow: " + score);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -1*thrust);
        }
        if (Input.GetKey(KeyCode.W))
        {

            rb.AddForce(0, 0, 1*thrust);
        }
        if (Input.GetKey(KeyCode.A))
        {

            rb.AddForce(-1*thrust, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {

            rb.AddForce(1*thrust, 0, 0);
        }
    }
}
