using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel; // ������\������UI-Text�I�u�W�F�N�g��ۑ�
    int kyori;              // ������ۑ�����ϐ�

    public Image timeGauge; // �^�C���Q�[�W��\������UI-Image�I�u�W�F�N�g��ۑ�

    float lastTime;         // �c�莞�Ԃ�ۑ�����ϐ�

    // Start is called before the first frame update
    void Start()
    {
        kyori = 0;
        lastTime = 5f; // �c�莞��100�b
    }

    // Update is called once per frame
    void Update()
    {
        // �c�莞�Ԃ����炷����
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        // �c�莞�Ԃ��O�ɂȂ����烊���[�h
        if(lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }


        // �i�񂾋�����\��
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";
    }
}






