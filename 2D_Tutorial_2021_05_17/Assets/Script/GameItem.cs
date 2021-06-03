using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItem : MonoBehaviour
{
    [SerializeField]
    UI2DSprite m_icon;
    [SerializeField]
    UILabel m_countLable;
    Inventory.ItemType m_type;

    byte m_count;
    public void SetItem(Inventory.ItemType type, Sprite icon, int count)
    {
        m_countLable.transform.parent.gameObject.SetActive(false);
        m_type = type;
        m_icon.sprite2D = icon;
        m_countLable.text = count.ToString();
        m_count = (byte)count;
        if(count > 1)
        {
            m_countLable.transform.parent.gameObject.SetActive(true);
        }
    }
    void Start()
    {

    }
}
