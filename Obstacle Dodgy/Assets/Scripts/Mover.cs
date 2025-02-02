using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 3f;
    Rigidbody rb;
    private int score;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime; ;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime; ;
        Vector3 moveDir = new Vector3(xValue, yValue, zValue).normalized;
        rb.AddForce(moveDir * moveSpeed, ForceMode.Acceleration);
    }

    public void IncrementScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}
