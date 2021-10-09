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
    public Image cardPrefab;

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

    // ÉJÅ[ÉhÇÃê∂ê¨
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
        Image instance = null;

        instance = Instantiate(cardPrefab);

        int cardId = data.cardId;

        instance.transform.SetParent(cardContent.transform, false);

        instance.gameObject.SetActive(true);
    }

}
