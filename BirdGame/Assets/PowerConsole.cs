using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerConsole : MonoBehaviour
{	
	public Power[] powerSet;
	public Text subTitle;
	public Text rule;
	public LayoutGroup myLayout;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void RandomPower()
	{		
		int powerRand = Mathf.FloorToInt(UnityEngine.Random.Range(0, powerSet.Length-1) );
		subTitle.text = powerSet[powerRand].title;
		// rule.text = powerSet[powerRand].rule;
		// rule.gameObject.SetActive(false);
		rule.text = System.String.Format(powerSet[powerRand].rule, "\n" );
		// rule.gameObject.SetActive(true);
		// myLayout.SetLayoutVertical();
	}
}
