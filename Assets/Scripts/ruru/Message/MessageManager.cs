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
        Debug.Log("���b�Z�[�W�\��");

        await navigator.Message(new string[] { "����̓e�X�g�ł��B",
                                               "�^�b�v����ƁA���̃��b�Z�[�W���\������܂��B",
                                               "���́A�e�L�X�g�{�b�N�X��",
                                               "�擾�ł������������b�Z�[�W��\������悤�ɂ��Ă��܂��B",
                                               "��������΁A�����Ă��������I"});

        MessagePanel.SetActive(false);
    }

}
