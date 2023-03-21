using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    //物件身上的動畫
    public Animator ObjAni;
    //聲音物件
    public AudioSource ObjAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //滑鼠或手指點擊有腳本的物件（此物件必須要有collider碰撞器）
    void OnMouseDown() {
        Debug.Log("滑鼠或手指點擊此物件");
        //當點擊該物件時，boolean值就會變成true，撥放該物件的動畫
        ObjAni.SetBool("play", true);
        //聲音播放
        ObjAudio.Play();
    }

    //滑鼠或手指離開此腳本的物件
    void OnMouseUp() {
        Debug.Log("滑鼠或手指離開此腳本");
        ObjAni.SetBool("play", false);
        //聲音停止
        ObjAudio.Stop();
    }
}
