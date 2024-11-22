using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{

    public Text scoreText;

    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    void Update()
    {
        transform.Rotate(10*Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter(Collider collision)
    {

        MovementController controller = collision.gameObject.GetComponent<MovementController>();
        if (controller != null)
        {
            controller.CollectScore();
            gameObject.SetActive(false);

            if (scoreText != null)
            {
                scoreText.text = "Score: " + controller.score;
            }
        }
    }
}
