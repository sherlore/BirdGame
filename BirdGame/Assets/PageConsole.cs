using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageConsole : MonoBehaviour
{
	public GameObject[] pages;
	public int nowPage;
	
    // Start is called before the first frame update
    void Start()
    {
		for(int i=0; i<pages.Length; i++)
		{
			pages[i].SetActive(false);
		}
		
		nowPage = 0;
		pages[nowPage].SetActive(true);		
    }
	
	public void ShowPage(int index)
	{
		if(nowPage == index ) return;
		
		pages[nowPage].SetActive(false);
		nowPage = index;
		pages[nowPage].SetActive(true);		
	}
}
