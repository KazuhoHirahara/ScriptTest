using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Boss
{
    private int hp = 100;           // 体力
    private int mp = 53;
    private int power = 25;         // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 魔法攻撃用の関数
    public void Magic()
    {

        if (mp > 5) {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else { 
        Debug.Log("MPが足りないため魔法が使えない。");
        }


    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}


public class Test : MonoBehaviour
{

    void Start()
    {

        // 配列を初期化する
        int[] array = { 2, 4, 6, 8, 10 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
                // 配列の要素を表示する
            Debug.Log(array[i]);
        }
        for (int i = 0; i < array.Length; i++)
        {

            // 配列の要素を表示する
            Debug.Log(array[array.Length - 1 - i]);
        }



        // Bossクラスの変数を宣言してインスタンスを代入
        Boss midboss = new Boss();

        // 攻撃用の関数を呼び出す
        midboss.Attack();
        // 防御用の関数を呼び出す
        midboss.Defence(99);
        // 魔法攻撃用の関数を呼び出す
        for (int i = 0; i < 10; i++)
        {
            midboss.Magic();
        }
        midboss.Magic();






    }

    // Update is called once per frame
    void Update()
    {

    }
}
