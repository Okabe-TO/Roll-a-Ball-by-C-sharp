using UnityEngine;

public class Item : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			// アイテム回収時の処理（例：スコアの追加など）
			Destroy(this.gameObject); // アイテムの削除
		}
	}
}
