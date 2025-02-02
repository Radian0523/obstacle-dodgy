using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] private float xAngle = 0f;
    [SerializeField] private float yAngle = 1f;
    [SerializeField] private float zAngle = 0f;
    [SerializeField] private float rotateSpeed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Spin();
    }

    void Spin()
    {
        Vector3 eulers = new Vector3(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime).normalized;
        transform.Rotate(eulers * rotateSpeed);
    }
}
