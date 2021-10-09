using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class Navigator : MonoBehaviour
{
    
    // ���b�Z�[�W�֌W�̏���
    public async Task Message(string[] messages_str)
    {
        // �e�L�X�g�R���|�[�l���g���擾
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();

        foreach (string message_str in messages_str)
        {
            // ���b�Z�[�W�e�L�X�g���Z�b�g
            messageText.text = message_str;

            // ��ʂ��^�b�v�����̂�҂�
            // 1ms���ƂɃ`�F�b�N����
            while (true)
            {
                await Task.Delay(1);

                if (Application.isEditor)
                {
                    if (Input.GetMouseButtonUp(0)) break;
                }
                else
                {
                    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) break;
                }
            }
        }
    }

    // ���b�Z�[�W�Ɠ����ɉ摜��\��������ꍇ
    // ���b�Z�[�W�ƃX�v���C�g�I�u�W�F�N�g�������ɕ\������ꍇ
    public async Task Message(string[] messages_str, GameObject obj)
    {
        // �e�L�X�gCompnent���擾����
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();

        obj.SetActive(true);

        foreach (string message_str in messages_str)
        {
            // ���b�Z�[�W�e�L�X�g���Z�b�g
            messageText.text = message_str;

            // ��ʂ��^�b�v�����̂�҂�
            // 1ms���Ƀ`�F�b�N����
            while (true)
            {
                await Task.Delay(1);
                if (Application.isEditor)
                {
                    if (Input.GetMouseButtonUp(0)) break;
                }
                else
                {
                    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) break;
                }

            }
        }

        obj.SetActive(false);
    }


}
