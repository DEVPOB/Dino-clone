using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float jumpforce;
    [SerializeField]bool isground = false;
    Rigidbody2D rb;
    bool dead = false;
    public TextMeshProUGUI score;
    int runscore = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.Space)))
        {
            if (isground == true)
            {
                rb.AddForce(Vector2.up * jumpforce);
                isground = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.S) || (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            if (isground == false)
            {
                rb.AddForce(Vector2.down * jumpforce);
                isground = true;
            }
        }
        if (dead != true)
        {
            runscore += 1;
            score.text = runscore.ToString();
        }
        if (dead == true)
        {
            SceneManager.LoadScene("Game");
        }
    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isground == false)
            {
                isground = true;
            }
        }
        if (collision.gameObject.CompareTag("spike"))
        {
            dead = true;
        }
    }
}
