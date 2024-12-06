using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public Score score;

    void Update()
    {
        transform.Rotate(25*Time.deltaTime, 30 * Time.deltaTime, 25 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collision)
    {

        MovementController controller = collision.gameObject.GetComponent<MovementController>();
        if (controller != null)
        {
            if (score != null)
            {
                score.AddPoint();
            }
                gameObject.SetActive(false);
        }
    }
}
