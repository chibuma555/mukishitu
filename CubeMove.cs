using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeMove : MonoBehaviour
{

    //public float speed;
    private Vector3 pos;
    private bool isStop = false;
    private float randomSpeed;

    /*
    private float timeReset = 5;
    private float time = 0;
    private bool flag;
    private float moveBox;
    */

    void Start()
    {

        pos = this.gameObject.transform.position;
        randomSpeed = Random.Range(1, 3f);
        /*
        StartCoroutine("CubeForward");
        time = 0;
        flag = true;
        */
    }

   

    void Update()
    {
        if (!isStop)
        {
            pos.y += Time.deltaTime * randomSpeed; // speedは移動速度
            transform.position = pos;

            if (pos.y > 3) // 終点（自由に変更可能）
            {
                isStop = true;
            }
        }
        else
        {
            pos.y -= Time.deltaTime * randomSpeed;
            transform.position = pos;

            if (pos.y < -3) // 始点（自由に変更可能）
            {
                isStop = false;
            }
        }



        /*
        time += Time.deltaTime;

        Vector3 p = new Vector3(0, moveBox, 0);
        transform.Translate(p);

        if (!flag)
        {
            if (time > timeReset)
            {
                StartCoroutine("CubeForward");
                time = 0;
                flag = true;
            }
        }

        if (flag)
        {
            if (time > timeReset)
            {
                StartCoroutine("CubeBack");
                time = 0;
                flag = false;
            }
        }
        */
    }

    /*
    IEnumerator CubeForward()
    {
        yield return null;
        moveBox = Random.Range(0f, 0.005f);
        Debug.Log("達成");
    }

    IEnumerator CubeBack()
    {
        yield return null;
        Random.InitState(40);
        Debug.Log("歩達成");
        moveBox *= -2;
    }
    */
}


