using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour{

    public static GameController instance;
    public GameObject gameOverText;
    public Text scoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public TextMeshProUGUI text;

    private int score = 0;

    AudioSource audioSource;
    public AudioClip scoreSound;

    // Start is called before the first frame update
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy (gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown (0)) 
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "score: " + score.ToString ();
        Playsound(scoreSound);
    }

    public void BirdDied()
    {
        gameOverText.SetActive (true);
        gameOver = true;

    }
    public void Playsound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
