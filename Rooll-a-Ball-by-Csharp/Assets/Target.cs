using UnityEngine;

public class Target : MonoBehaviour
{
	public Transform player;	// プレイヤーへの参照
	private Vector3 offset;		// 初期相対位置
	
	// Start is called before the first frame update
	void Start()
    {
		offset = transform.position - player.position;	// 初期相対位置の計算
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;	// カメラの位置の更新
    }
}
