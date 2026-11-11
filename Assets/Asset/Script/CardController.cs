using UnityEngine;
using UnityEngine.UI;
public class CardController : MonoBehaviour
{
    public Button currentBtn;
    public Image icon;
    public int id;
    private void Awake()
    {
        currentBtn = GetComponent<Button>();
    }
    public void InitCard(int _id, Sprite iconSprite)
    {
        id = _id;
        icon.sprite = iconSprite;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
