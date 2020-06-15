using UnityEngine;

// マウス位置に追従するオブジェクトにアタッチする（範囲制限つき、2Dプロジェクト用）
// 解説記事　http://negi-lab.blog.jp/MouseFollow2D
public class a : MonoBehaviour
{
    // X, Y座標の移動可能範囲

    private void Update()
    {
        // マウス位置をスクリーン座標からワールド座標に変換する
        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Z座標を修正する
        targetPos.y = 0.2f;
        targetPos.z = -3f;

        // このスクリプトがアタッチされたゲームオブジェクトを、マウス位置に線形補間で追従させる
        transform.position = Vector3.Lerp(transform.position, targetPos, 1);
    }
}