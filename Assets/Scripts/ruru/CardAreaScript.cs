using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class CardData
{
    public int cardId = 0;
    public string cardName = "";
    public Sprite sprite = null;
}

public class CardAreaScript : MonoBehaviour
{
    public Button cardPrefab;

    [SerializeField] GameObject cardContent = null;

    public int cardId = 0;

    private void Start()
    {
        cardId = 0;
    }

    private void Update()
    {
        if (cardId != 0)
        {
            CreateCard(cardId);
        }
    }

    // カードの生成
    private void CreateCard(int cardId)
    {

        CardData data = new CardData();

        data.cardId = cardId;

        CardInstance(data);

       // Instantiate(cardPrefab);

        this.cardId = 0;
    }


    private void CardInstance(CardData data)
    {
        Button instance = null;

        instance = Instantiate(cardPrefab);

        Text cardText = instance.gameObject.transform.GetChild(0).GetComponent<Text>();

        int cardId = data.cardId;
        cardText.text = "カードID" + cardId;

        instance.transform.SetParent(cardContent.transform, false);

        instance.onClick.AddListener(() =>
        {
            // 全選択パネルを取得する
            GameObject[] dropAreas = GameObject.FindGameObjectsWithTag("test");

            foreach (GameObject dropArea in dropAreas)
            {
                SpriteRenderer spriteRenderer = dropArea.GetComponent<SpriteRenderer>();
                Debug.Log(spriteRenderer);
                spriteRenderer.color = Color.gray;
                GameManager.instance.CardId = cardId;
            }

        });

        instance.gameObject.SetActive(true);
    }

}
