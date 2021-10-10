using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int cardId;

    public int CardId { get { return cardId; } set { cardId = value; } }

    public GameObject[] mapObjList = null;

    public SpriteContener sc = null;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayBGM(0);

        mapObjList = GameObject.FindGameObjectsWithTag("test");
        Debug.Log("ƒeƒXƒg" + mapObjList);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
