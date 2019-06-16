using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickObject : MonoBehaviour
{
    public Control con;
    public Material red, green, blue, white;
    private int arrayx, arrayy;
    // Start is called before the first frame update
    void Start()
    {
        con = GetComponent<Control>();     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "cel")
                {
                    checkName(hit.transform.name);
                   
                    if (con.arrayList[arrayx+1, arrayy+1] == 0)
                    {
                        hit.transform.gameObject.GetComponent<Renderer>().material = green;
                        con.arrayList[arrayx+1, arrayy+1] = 1;
                    }
                    else
                    {
                        hit.transform.gameObject.GetComponent<Renderer>().material = white;
                        con.arrayList[arrayx+1, arrayy+1] = 0;
                    }
                    Debug.Log(con.arrayList[arrayx + 1, arrayy + 1]);
                    arrayx = 0;
                    arrayy = 0;

                }
            }
               

            
        }
    }
    public void checkName(string name)
    {
        Debug.Log(((int)name[0]-65)+","+((int)name[1]-49));
        arrayx = (int)name[0] - 65;
        arrayy = (int)name[1] - 49;
    }
   public IEnumerator changeBlue(string name)
    {

        yield return new WaitForSeconds(0.1f);
        GameObject.Find(name).GetComponent<Renderer>().material = blue;
    }
    public IEnumerator changeRed(string name)
    {
        yield return new WaitForSeconds(0.1f);
        GameObject.Find(name).GetComponent<Renderer>().material = red;
    }
    public IEnumerator changeGreen(string name)
    {
        yield return new WaitForSeconds(0.1f);
        GameObject.Find(name).GetComponent<Renderer>().material = green;
    }
    public IEnumerator changeWhite(string name)
    {
        yield return new WaitForSeconds(0.1f);
        GameObject.Find(name).GetComponent<Renderer>().material = white;
    }
}
