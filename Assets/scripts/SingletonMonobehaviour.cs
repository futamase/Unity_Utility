using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonobehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T mInstance;
    public static T Instance {
        get {
            if(mInstance == null) {
				// 一応、すでに同じオブジェクトが存在しないか確認
				// 検索コストが高いと感じるのであれば、この判定は消していい
                mInstance = (T)FindObjectOfType(typeof(T));
                if (mInstance == null) {
					GameObject obj = new GameObject();
                    mInstance = obj.AddComponent<T>();
					
					// 渡されたジェネリッククラス名を名前に出来る
                    obj.name = mInstance.GetType().Name;
					
					// 破棄されたくないので、これを読んでおく
                    DontDestroyOnLoad(obj);
                }
            }
            return mInstance;
        }
    }
}
