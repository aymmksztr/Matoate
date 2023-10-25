using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject prefabBullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) 
        {
            // 話されたマウスの場所へレイ（光線）を飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // ベクトル（ワールド座標）を取得
            Vector3 dir = ray.direction;

            GameObject bullet = Instantiate(prefabBullet);

            // 発射
            bullet.transform.position = transform.position;
            bullet.GetComponent<BulletController>().Shoot(dir.normalized * 3000);
        }
    }
}
