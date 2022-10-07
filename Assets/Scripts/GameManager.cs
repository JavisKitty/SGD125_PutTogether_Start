using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region 
    public static GameManager gm;
    public Transform[] nodes;
    void Awake()
    {
        if (!gm) gm = this;
        else Destroy(this);
    }
    #endregion
    public GameObject player;

}
