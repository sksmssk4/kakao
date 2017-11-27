using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellNum : MonoBehaviour {
    static int counter = 0;
    static int n = 4;
    static int m = 5;
    // Use this for initialization
    void Start()
    {

        int[,] array = new int[4, 5] { { 3, 3, 2, 4, 5 }, { 1, 1, 1, 1, 5 }, { 1, 1, 1, 1, 6 }, { 3, 3, 2, 2, 6 } };
        //같은숫자 세기
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                if ((array[i, j] == array[i + 1, j]) && (array[i, j] == array[i, j + 1]) && (array[i, j] == array[i + 1, j + 1]))
                {
                    counter += 4;
                }
            }

        }
        //가로 중복제거(이미 해당된 줄 중복계산 방지)
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                if ((array[i, j] == array[i + 1, j]) && (array[i, j] == array[i, j + 1]) && (array[i, j] == array[i + 1, j + 1]) && (array[i, j] == array[i + 2, j]) && (array[i, j] == array[i + 2, j + 1]))
                {
                    counter -= 2;
                }
            }
        }
        //세로 중복제거(이미 해당된 줄 중복계산 방지)
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                if ((array[i, j] == array[i + 1, j]) && (array[i, j] == array[i, j + 1]) && (array[i, j] == array[i + 1, j + 1]) && (array[i, j] == array[i, j+2]) && (array[i, j] == array[i + 1, j + 2]))
                {
                    counter -= 2;
                }
            }
        }
    }
	// Update is called once per frame
	void Update () {

        Debug.Log(counter);
    }
    
       
}
    

    
