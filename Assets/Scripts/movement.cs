using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Text pauseText;
    private bool isPaused = false;
    public GameObject reward;
    public GameObject reward2;
    public GameObject reward3;
    public GameObject reward4;
    public GameObject reward5;
    public float movement = 4.0f;
    public float speed = 1.0f;
    public int score = 0;
    public Text scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        if(isPaused == false)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                MoveForward();
            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                MoveBack();
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                MoveLeft();
            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                MoveRight();
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; 
            if (pauseText != null)
            {
                pauseText.text = "Pause"; 
            }
        }
        else
        {
            Time.timeScale = 1f; 
            if (pauseText != null)
            {
                pauseText.text = ""; 
            }
        }
    }

    private void MoveLeft()
    {
        this.transform.Translate(speed * movement * Time.deltaTime * Vector3.left);
    }

    public void MoveRight()
    {
        this.transform.Translate(speed * movement * Time.deltaTime * Vector3.right);
    }

    private void MoveForward()
    {
        this.transform.Translate(speed * movement * Time.deltaTime * Vector3.forward);
    }

    private void MoveBack()
    {
        this.transform.Translate(speed * movement * Time.deltaTime * Vector3.back);
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    } 

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Reward"))
        {
            score++;
            UpdateScoreText();
            Destroy(other.gameObject);
        }
        if (score == 5)
        {
            SceneManager.LoadScene("Exit");
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }



}
