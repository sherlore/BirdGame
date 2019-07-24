using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DictionaryConsole : MonoBehaviour
{
	public bool showField;
	public int fieldIndex;
	public int powerIndex;
	public FieldConsole fieldConsole;
	public PowerConsole powerConsole;
		
	public Text title;
	public Text subTitle;
	public Text rule;
	
	public GameObject checkField;
	public GameObject checkPower;
	
    // Start is called before the first frame update
    void OnEnable()
    {
		SetField(true);
    }

	
	public void SetField(bool val)
	{		
		showField = val;
		
		checkField.SetActive(!showField);
		checkPower.SetActive(showField);
		
		UpdateDictionary();
	}
	
	public void ShowNext(bool isNext)
	{
		if(isNext)
		{
			if(showField)
			{
				if(fieldIndex < fieldConsole.fieldSet.Length-1)
				{
					fieldIndex++;
				}
				else
				{
					fieldIndex = 0;
				}
			}
			else
			{
				if(powerIndex < powerConsole.powerSet.Length-1)
				{
					powerIndex++;
				}
				else
				{
					powerIndex = 0;
				}
			}
		}
		else
		{
			if(showField)
			{
				if(fieldIndex > 0)
				{
					fieldIndex--;
				}
				else
				{
					fieldIndex = powerConsole.powerSet.Length-1;
				}
			}
			else
			{
				if(powerIndex > 0)
				{
					powerIndex--;
				}
				else
				{
					powerIndex = powerConsole.powerSet.Length-1;
				}
			}
		}
		
		UpdateDictionary();
	}
	
	public void UpdateDictionary()
	{
		if(showField)
		{
			title.text = System.String.Format("場地規則 No.{0}", fieldIndex+1 );	
			
			subTitle.text = fieldConsole.fieldSet[fieldIndex].title;
			rule.text = fieldConsole.fieldSet[fieldIndex].rule;
		}
		else
		{
			title.text = System.String.Format("異能 No.{0}", powerIndex+1 );	
			
			subTitle.text = powerConsole.powerSet[powerIndex].title;
			rule.text = System.String.Format(powerConsole.powerSet[powerIndex].rule, "\n" );
		}
	}
}
