using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startListener : MonoBehaviour {

    public GameObject title;  //声明需要得到的游戏物体,在Unity界面进行赋值
    private MeshRenderer meshrenderer;  //声明需要得到的组件
    
    public void Click()
    {
         meshrenderer = title.GetComponent<MeshRenderer>();  //得到Player1的MeshRenderer组件
        meshrenderer.enabled = false;
        //SceneManager.LoadScene(1);
    }
}
