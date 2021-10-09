using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;


public class MessageManager : MonoBehaviour
{
    [SerializeField] Navigator navigator = null;

    [SerializeField] GameObject MessagePanel = null;

    // Start is called before the first frame update
    async void Start()
    {

        if (MessagePanel.activeSelf)
        {
            await Message();
        }
    }

    async Task Message()
    {
        Debug.Log("メッセージ表示");

        await navigator.Message(new string[] { "これはテストです。",
                                               "タップすると、次のメッセージが表示されます。",
                                               "今は、テキストボックスが",
                                               "取得できた時だけメッセージを表示するようにしています。",
                                               "何かあれば、教えてください！"});

        MessagePanel.SetActive(false);
    }

}
