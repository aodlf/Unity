using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour // mono로 동작, 유니티 기본 동작, 자동상속
{
    [SerializeField]
    float m_speed = 3f;
    [SerializeField]
    Vector3 m_dir;
    [SerializeField]
    Animator m_animator;
    [SerializeField]
    SpriteRenderer m_sprRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        
        m_animator = gameObject.GetComponent<Animator>();
        m_sprRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void KeyControll()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            m_dir = Vector3.zero;
            m_animator.SetBool("IsMove", false);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            m_dir = Vector3.zero;
            m_animator.SetBool("IsMove", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_dir = Vector3.left;
            m_animator.SetBool("IsMove", true);
            m_sprRenderer.flipX = false;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_dir = Vector3.right;
            m_animator.SetBool("IsMove", true);
            m_sprRenderer.flipX = true;
        }
        gameObject.transform.position += m_dir * m_speed * Time.deltaTime;
    }

    // Update is called once per frame // 반복
    void Update()
    {
        KeyControll();
    }
        
}
