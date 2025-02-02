using Unity.VisualScripting;
using UnityEngine;

public class HitColorChange : MonoBehaviour
{
    bool isColorChange;
    Color orgColor;
    MeshRenderer meshRenderer;
    float timer;
    Mover player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        orgColor = meshRenderer.material.color;
        player = FindFirstObjectByType<Mover>();
    }

    // Update is called once per frame
    void Update()
    {
        ColorChange();
    }

    void ColorChange()
    {
        if (!isColorChange)
        {
            return;
        }

        timer += Time.deltaTime;
        meshRenderer.material.color = Color.red;
        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        }
        if (timer >= 1f)
        {
            timer = 0;
            meshRenderer.material.color = orgColor;
            isColorChange = false;

        }



    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && isColorChange == false)
        {
            isColorChange = true;
            player.IncrementScore();
            Debug.Log(player.GetScore());
        }
    }
}
