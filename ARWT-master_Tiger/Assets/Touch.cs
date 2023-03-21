using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    //物件身上的Animator
    public Animator ObjAni;

    //滑鼠或手指點到有腳本的物件(此物件必須要有Collider碰撞器)
     void OnMouseDown() {
        Debug.Log("滑鼠或手指點下物件");
        //Animator中bool名稱為Player的變數變為true，執行自己做的動畫
        ObjAni.SetBool("Run",true);

    }
    //滑鼠或手指離開此物件
    void OnMouseUp() {
        Debug.Log("滑鼠或手指離開物件");
        //Animator中bool名稱為Player的變數變為false，回到預設動畫
        ObjAni.SetBool("Run",false);

    }
}
