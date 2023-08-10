using UnityEngine;
using TMPro; // TextMeshProの名前空間を追加

public class CountItem : MonoBehaviour
{
	public TextMeshProUGUI scoreLabel; // TextMeshProUGUI型に変更
	public TextMeshProUGUI clearText;

	void Start()
	{
		clearText.gameObject.SetActive(false);
	}

	void Update()
	{
		int itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
		scoreLabel.text = itemCount.ToString();

		// 全て取得された時
		if(itemCount == 0)
		{
			clearText.gameObject.SetActive(true);
		}
	}
}
