using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropArea : MonoBehaviour
{
    private bool enterFlag = false;
    private bool upFlag = false;

    public void EnterFlag()
    {
        Debug.Log("Enter");
    }

    public void UpFlag()
    {
        Debug.Log("Up");
    }

    public void PointerUp()
    {
        if (GameManager.instance.CardId != 0)
        {
            SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();
            sprite.sprite = GameManager.instance.sc.spriteList[GameManager.instance.CardId - 1];

            // 全てのスプライトの色を元に戻す
            foreach (GameObject mapObj in GameManager.instance.mapObjList)
            {
                SpriteRenderer sr = mapObj.GetComponent<SpriteRenderer>();
                sr.color = Color.white;
            }

            GameManager.instance.CardId = 0;
        }
    }

    public void DestroyObj()
    {
        Destroy(this.gameObject);
    }
}
