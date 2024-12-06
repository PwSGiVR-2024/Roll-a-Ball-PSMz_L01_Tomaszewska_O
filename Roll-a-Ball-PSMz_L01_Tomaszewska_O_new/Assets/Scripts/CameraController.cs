using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    Vector3 offset;

    void Start()
    {
        offset = player.transform.position - transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position - offset;
    }
}
