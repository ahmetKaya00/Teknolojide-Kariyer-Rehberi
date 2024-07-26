using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float ziplama = 10f;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    public string CurrentColor;

    public Color ColorCam, ColorSari, ColorPembe, ColorEflatun;

    public Text txt, PScore, PHScore;
    public int deger, number;

    public GameObject bir, iki, uc, dort, Panel;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        rb.bodyType = RigidbodyType2D.Static;
        RandomColor();
        Panel.SetActive(false);
        PHScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        Time.timeScale = 1f;
    }

    void Update()
    {
        txt.text = deger.ToString("f0");
        if(Input.GetButtonDown("Jump") || (Input.GetMouseButtonDown(0) || Input.touchCount > 0))
        {
            rb.velocity = Vector2.up * ziplama;
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ColorChanger")
        {
            RandomColor();
            collision.gameObject.transform.position = transform.position + new Vector3(0f, 17f, 0f);
            bir.transform.position = transform.position + new Vector3(0f, 15f, 0f);
            deger++;
            number++;
            PScore.text = number.ToString();
            if(number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
                PHScore.text = number.ToString();
            }
            return;
        }
        if(collision.tag == "Two")
        {
            RandomColor();
            collision.gameObject.transform.position = transform.position + new Vector3(0f, 17f, 0f);
            iki.transform.position = transform.position + new Vector3(0f, 15f, 0f);
            deger++;
            number++;
            PScore.text = number.ToString();
            if (number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
                PHScore.text = number.ToString();
            }
            return;
        }
        if (collision.tag == "Three")
        {
            RandomColor();
            collision.gameObject.transform.position = transform.position + new Vector3(0f, 17f, 0f);
            uc.transform.position = transform.position + new Vector3(0f, 15f, 0f);
            dort.transform.position = transform.position + new Vector3(0f, 15f, 0f);
            deger++;
            number++;
            PScore.text = number.ToString();
            if (number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
                PHScore.text = number.ToString();
            }
            return;
        }
        if(collision.tag != CurrentColor)
        {
            Panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void RandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                CurrentColor = "Cam";
                sr.color = ColorCam;
                break;
            case 1:
                CurrentColor = "Sari";
                sr.color = ColorSari;
                break;
            case 2:
                CurrentColor = "Pembe";
                sr.color = ColorPembe;
                break;
            case 3:
                CurrentColor = "Eflatun";
                sr.color = ColorEflatun;
                break;
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Panel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
