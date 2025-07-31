using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce = 10f;
    [SerializeField]
    private GameObject _menu;


    private int _score = 0;

    public int Score
    {
        get
        {
            return _score;
        }
    }
    public bool IsAlive
    {
        get
        {
            return gameObject.activeSelf;
        }
    }

    private Animator animator;
    private Rigidbody2D rb;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocityY = _jumpForce;
        }
    }
    private void OnollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        _menu.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("We passed the pipes!"); 
    }
}
