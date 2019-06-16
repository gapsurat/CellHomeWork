using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int[,] arrayList;
    public OnClickObject onClick;
    public int x = 8, y = 6,z,tint;
    public int checkHave = 1,haveCel=0;
    public string tString,fString,zString;
    public char c;
    // Start is called before the first frame update
    void Start()
    {
        arrayList = new int[10, 10];
        for (int i = 0; i <= x+1; i++)
        {
            for(int j = 0; j <= y+1; j++)
            {
                arrayList[i, j] = 0;
            }
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(arrayList[0,1]);
    }

    public void Spawn()
    {
         
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= y; j++)
            {
                if (arrayList[i, j] == 0)
                {
                    if (arrayList[i - 1, j - 1] == 1 )
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i, j - 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i + 1, j - 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i - 1, j] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i + 1, j] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i - 1, j + 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i, j + 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i + 1, j + 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (haveCel == 3)
                    {
                        arrayList[i, j] = 2;

                          z= ((i * 10) + j);
                       
                        tString = z.ToString();
                        tint = 65 + i-1;
                        c = (char)tint;

                        zString = c.ToString();
                        fString = zString + (j).ToString();
                        StartCoroutine(onClick.changeBlue(fString));
                        onClick.changeBlue(fString);
                        Debug.Log(fString);
                       
                    }
                    haveCel = 0;
          
                }
            }
        }
    }
    public void DeSpawn()
    {

        for (int i = 1; i <= x+1; i++)
        {
            for (int j = 1; j <= y; j++)
            {
             
                if (arrayList[i, j] == 1)
                {
                   
                    if (arrayList[i - 1, j - 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i, j - 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i + 1, j - 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i - 1, j] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i + 1, j] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i - 1, j + 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i, j + 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if (arrayList[i + 1, j + 1] == 1)
                    {
                        haveCel += 1;
                    }
                    if ((haveCel < 2 && haveCel >= 0) || haveCel > 3)
                    {
                        arrayList[i, j] = 3;

                        z = ((i * 10) + j);

                        tString = z.ToString();
                        tint = 65 + i - 1;
                        c = (char)tint;

                        zString = c.ToString();
                        fString = zString + (j).ToString();
                        StartCoroutine(onClick.changeRed(fString));
                        onClick.changeRed(fString);
                        Debug.Log(fString);
                    }
                    haveCel = 0;
             
                }

            }
        }
    }
    public void FiSpawn()
    {

        for (int i = 1; i <= x + 1; i++)
        {
            for (int j = 1; j <= y; j++)
            {
                if (arrayList[i, j] == 1 || arrayList[i, j] == 2)
                {
                    arrayList[i, j] = 1;
                    z = ((i * 10) + j);

                    tString = z.ToString();
                    tint = 65 + i - 1;
                    c = (char)tint;

                    zString = c.ToString();
                    fString = zString + (j).ToString();
                    StartCoroutine(onClick.changeGreen(fString) );
                 
                    Debug.Log(fString);
             
                }
                else
                {
                    arrayList[i, j] = 0;
                    z = ((i * 10) + j);

                    tString = z.ToString();
                    tint = 65 + i - 1;
                    c = (char)tint;

                    zString = c.ToString();
                    fString = zString + (j).ToString();
                    StartCoroutine(onClick.changeWhite(fString));
            
                    Debug.Log(fString);
                }
       
            }
        }
    }
    public IEnumerator delay()
    {
 
        yield return new WaitForSeconds(1f);
   
    }
}
