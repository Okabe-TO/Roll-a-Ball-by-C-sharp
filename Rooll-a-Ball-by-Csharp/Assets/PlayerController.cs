using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 5.0f; // プレイヤーの移動速度を制御する変数
	private Rigidbody rb; // Rigidbodyコンポーネントへの参照

	void OnCollisionEnter(Collision collision)
	{
		// 危険な壁との衝突を検出
		if (collision.gameObject.CompareTag("DangerWall"))
		{
			// ゲームオーバーの処理（例：シーンのリロード）
			UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
		}
	}

	void Start()
	{
		// ゲームが始まったときにRigidbodyコンポーネントを取得
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		// 水平方向（左右）の入力を取得（-1から1の値）
		float moveHorizontal = Input.GetAxis("Horizontal");
		// 垂直方向（前後）の入力を取得（-1から1の値）
		float moveVertical = Input.GetAxis("Vertical");

		// 入力値に基づいて移動方向を計算
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		// 計算された方向に力を加えて、ボールを転がす
		// speed変数を使って移動速度を調整
		rb.AddForce(movement * speed);
	}
}
