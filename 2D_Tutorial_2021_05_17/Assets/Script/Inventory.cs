using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum ItemType
    {
        Ball,
        Bomb,
        Hat,
        Magnet,
        Max
    }
    [SerializeField]
    Sprite[] m_itemIconSprites;
    [SerializeField]
    GameObject m_itemSlotPrefab;
    [SerializeField]
    GameObject m_gameItemPrefab;
    [SerializeField]
    UIGrid m_slotGrid;
    [SerializeField]
    Transform m_slotCursor;
    [SerializeField]
    TweenScale m_tween;
    int m_itemSlotMax = 24;
    List<ItemSlot> m_slotList = new List<ItemSlot>();

    public void Open()
    {
        if(!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
            m_tween.ResetToBeginning();
            m_tween.PlayForward();
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    public void OnSelectSlot(ItemSlot slot)
    {
        for(int i =0; i < m_slotList.Count; i++)
        {
            //if (m_slotList[i].IsSelect)
            //{
            //    m_slotList[i].IsSelect = false;
            //}
            var result = m_slotList.Find(obj => obj.IsSelect);
            if (result != null) result.IsSelect = false;

            slot.IsSelect = true;
            
        }
    }
    public void CreateGameItem()
    {
        for(int i = 0; i < m_slotList.Count; i++)
        {
            if(m_slotList[i].IsEmpty)
            {
                ItemType type = (ItemType)Random.Range((int)ItemType.Ball, (int)ItemType.Max);
                int count = Random.Range(1, 5);
                var obj = Instantiate(m_gameItemPrefab);
                obj.transform.SetParent(m_slotList[i].transform);
                obj.transform.localPosition = Vector3.zero;
                obj.transform.localScale = Vector3.one;
                var item = obj.GetComponent<GameItem>();
                item.SetItem(type, m_itemIconSprites[(int)type], count);
                m_slotList[i].SetSlot(item);
                break;
            }
        }
        
    }

    void CreateItemSlot(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var obj = Instantiate(m_itemSlotPrefab);
            obj.transform.SetParent(m_slotGrid.transform);
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localScale = Vector3.one;
            var slot = obj.GetComponent<ItemSlot>();
            slot.InitSlot(this);
            m_slotList.Add(slot);
        }
    }
    void InitInventory()
    {
        CreateItemSlot(m_itemSlotMax);
    }
    // Start is called before the first frame update
    void Start()
    {
        InitInventory();
    }

    // Update is called once per frame
   
}
