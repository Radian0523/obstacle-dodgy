using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Transform player;
    Vector3 playerPos;
    float maxDistanceDelta = 1f;
    [SerializeField] private float flySpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowordsPlayer();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }

    void MoveTowordsPlayer()
    {
        maxDistanceDelta = flySpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, maxDistanceDelta);
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
