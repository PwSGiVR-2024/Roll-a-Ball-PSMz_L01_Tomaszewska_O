using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{

    public Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10*Time.deltaTime, 0, 0);
    }
    void OnTriggerEnter(Collider collision)
    {
    
        collision.gameObject.GetComponent<MovementController>().CollectScore();
        gameObject.SetActive(false);
        scoreText.text = "Score: " + collision.gameObject.GetComponent<MovementController>().score;

    }
}
