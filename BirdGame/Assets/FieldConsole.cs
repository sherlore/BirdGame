using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldConsole : MonoBehaviour
{
	public Text member;
	public Text score;
	public string[] scoreSet;
	
	public Field[] fieldSet;
	public Text subTitle;
	public Text rule;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void RandomField()
	{
		int memberRand = Mathf.FloorToInt(UnityEngine.Random.Range(2f, 10f) );
		memberRand = memberRand > 6 ? 6 : memberRand;
				
		member.text = String.Format("球員人數: {0}", memberRand );		
		score.text = String.Format("三局分數: {0}", scoreSet[Mathf.FloorToInt(UnityEngine.Random.Range(0, scoreSet.Length-1) )] );
		
		int fieldRand = Mathf.FloorToInt(UnityEngine.Random.Range(0, fieldSet.Length-1) );
		subTitle.text = fieldSet[fieldRand].title;
		rule.text = fieldSet[fieldRand].rule;
	}
}
