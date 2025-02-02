using UnityEngine;

public class TriggerProjectiles : MonoBehaviour
{
    const int projectileNum = 4;
    [SerializeField] private GameObject[] projectile;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < projectileNum; i++)
            {
                //SetActive(false)と、Destroy(gameObject)の違いは、再利用できるかどうかで、後者の方が変更は遅い。
                //球や敵などはDestroyを使う
                projectile[i].SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}
