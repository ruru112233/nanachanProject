using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float speed = 1.0f;

    bool rightFlag = false;

    float time = 0;

    // ÉJÅ[ÉhID
    [SerializeField] int cardId;

    CardAreaScript cardAreaScript = null;

    // Start is called before the first frame update
    void Start()
    {
        cardAreaScript = GameObject.FindWithTag("CardArea").GetComponent<CardAreaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 5.0f)
        {
            time = 0;
            rightFlag = !rightFlag;
        }

        //if (rightFlag)
        //{
        //    transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //}
        //else
        //{
        //    transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cardAreaScript.cardId = cardId;
            this.gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }

}
