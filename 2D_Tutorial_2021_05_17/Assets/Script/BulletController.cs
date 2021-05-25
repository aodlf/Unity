using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Vector3 m_dir = Vector3.left;
    [SerializeField]
    float m_speed = 10f;
    [SerializeField]
    SpriteRenderer m_sprRenderer;
    [SerializeField]
    float m_lifetime = 3f;
    float m_time;

    public void SetBullet(Vector3 pos, Vector3 dir)
    {
        transform.position = pos;
        m_dir = dir;
        m_sprRenderer.flipY = dir == Vector3.right ? true : false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;
        if(m_time > m_lifetime)
        {
            m_time = 0f;
            Destroy(gameObject);
        }
        gameObject.transform.position += m_dir * m_speed * Time.deltaTime;
    }
}
