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
            // �b���ꂽ�}�E�X�̏ꏊ�փ��C�i�����j���΂�
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // �x�N�g���i���[���h���W�j���擾
            Vector3 dir = ray.direction;

            GameObject bullet = Instantiate(prefabBullet);

            // ����
            bullet.transform.position = transform.position;
            bullet.GetComponent<BulletController>().Shoot(dir.normalized * 3000);
        }
    }
}
