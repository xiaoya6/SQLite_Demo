using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //是否在线
    public bool isLine;  
    public string playerName;
    public string money;

    //拥有的卡片
    public ICard[] belongCard;
    //所对应的卡片的数量
    public int[] cardNumber;
    
	
}
