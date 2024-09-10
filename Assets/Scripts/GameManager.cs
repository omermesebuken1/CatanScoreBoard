using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI p1_1;
    public TextMeshProUGUI p1_2;
    public TextMeshProUGUI p1_3;
    public TextMeshProUGUI p1_4;
    public TextMeshProUGUI p1_5;

    public TextMeshProUGUI p2_1;
    public TextMeshProUGUI p2_2;
    public TextMeshProUGUI p2_3;
    public TextMeshProUGUI p2_4;
    public TextMeshProUGUI p2_5;

    public TextMeshProUGUI p3_1;
    public TextMeshProUGUI p3_2;
    public TextMeshProUGUI p3_3;
    public TextMeshProUGUI p3_4;
    public TextMeshProUGUI p3_5;

    public TextMeshProUGUI p4_1;
    public TextMeshProUGUI p4_2;
    public TextMeshProUGUI p4_3;
    public TextMeshProUGUI p4_4;
    public TextMeshProUGUI p4_5;


    public TextMeshProUGUI p1_total;
    public TextMeshProUGUI p2_total;
    public TextMeshProUGUI p3_total;
    public TextMeshProUGUI p4_total;


    private int p1_1_num;
    private int p1_2_num;
    private int p1_3_num;
    private int p1_4_num;
    private int p1_5_num;
    private int p1_total_num;

    private int p2_1_num;
    private int p2_2_num;
    private int p2_3_num;
    private int p2_4_num;
    private int p2_5_num;
    private int p2_total_num;

    private int p3_1_num;
    private int p3_2_num;
    private int p3_3_num;
    private int p3_4_num;
    private int p3_5_num;
    private int p3_total_num;

    private int p4_1_num;
    private int p4_2_num;
    private int p4_3_num;
    private int p4_4_num;
    private int p4_5_num;
    private int p4_total_num;

    public List<GameObject> changeButtons;
    public List<GameObject> yolButtons;
    public List<GameObject> orduButtons;
    private bool edit;

    private void Start()
    {
        resetNumbers();
        updateNumbers();
        foreach (var item in changeButtons)
        {
            item.SetActive(false);
        }
        foreach (var item in yolButtons)
        {
            item.SetActive(false);
        }
        foreach (var item in orduButtons)
        {
            item.SetActive(false);
        }
        edit = false;

        yolButtons[0].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
        yolButtons[1].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
        yolButtons[2].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
        yolButtons[3].GetComponent<Image>().color = new Color32(77, 77, 77, 255);

        orduButtons[0].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
        orduButtons[1].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
        orduButtons[2].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
        orduButtons[3].GetComponent<Image>().color = new Color32(77, 77, 77, 255);



    }


    private void updateNumbers()
    {

        if (p1_1_num < 0)
            p1_1_num = 0;

        if (p1_2_num < 0)
            p1_2_num = 0;

        if (p1_3_num < 0)
            p1_3_num = 0;

        if (p1_4_num < 0)
            p1_4_num = 0;

        if (p1_5_num < 0)
            p1_5_num = 0;



        if (p2_1_num < 0)
            p2_1_num = 0;

        if (p2_2_num < 0)
            p2_2_num = 0;

        if (p2_3_num < 0)
            p2_3_num = 0;

        if (p2_4_num < 0)
            p2_4_num = 0;

        if (p2_5_num < 0)
            p2_5_num = 0;


        if (p3_1_num < 0)
            p3_1_num = 0;

        if (p3_2_num < 0)
            p3_2_num = 0;

        if (p3_3_num < 0)
            p3_3_num = 0;

        if (p3_4_num < 0)
            p3_4_num = 0;

        if (p3_5_num < 0)
            p3_5_num = 0;


        if (p4_1_num < 0)
            p4_1_num = 0;

        if (p4_2_num < 0)
            p4_2_num = 0;

        if (p4_3_num < 0)
            p4_3_num = 0;

        if (p4_4_num < 0)
            p4_4_num = 0;

        if (p4_5_num < 0)
            p4_5_num = 0;

        p1_total_num = p1_1_num + (p1_2_num * 2) + p1_3_num + p1_4_num + p1_5_num;
        p2_total_num = p2_1_num + (p2_2_num * 2) + p2_3_num + p2_4_num + p2_5_num;
        p3_total_num = p3_1_num + (p3_2_num * 2) + p3_3_num + p3_4_num + p3_5_num;
        p4_total_num = p4_1_num + (p4_2_num * 2) + p4_3_num + p4_4_num + p4_5_num;

        p1_1.text = p1_1_num.ToString();
        p1_2.text = p1_2_num.ToString();
        p1_3.text = p1_3_num.ToString();
        p1_4.text = p1_4_num.ToString();
        p1_5.text = p1_5_num.ToString();

        p2_1.text = p2_1_num.ToString();
        p2_2.text = p2_2_num.ToString();
        p2_3.text = p2_3_num.ToString();
        p2_4.text = p2_4_num.ToString();
        p2_5.text = p2_5_num.ToString();

        p3_1.text = p3_1_num.ToString();
        p3_2.text = p3_2_num.ToString();
        p3_3.text = p3_3_num.ToString();
        p3_4.text = p3_4_num.ToString();
        p3_5.text = p3_5_num.ToString();

        p4_1.text = p4_1_num.ToString();
        p4_2.text = p4_2_num.ToString();
        p4_3.text = p4_3_num.ToString();
        p4_4.text = p4_4_num.ToString();
        p4_5.text = p4_5_num.ToString();

        p1_total.text = p1_total_num.ToString();
        p2_total.text = p2_total_num.ToString();
        p3_total.text = p3_total_num.ToString();
        p4_total.text = p4_total_num.ToString();




    }

    public void resetNumbers()
    {
        p1_1_num = 0;
        p1_2_num = 0;
        p1_3_num = 0;
        p1_4_num = 0;
        p1_5_num = 0;

        p2_1_num = 0;
        p2_2_num = 0;
        p2_3_num = 0;
        p2_4_num = 0;
        p2_5_num = 0;

        p3_1_num = 0;
        p3_2_num = 0;
        p3_3_num = 0;
        p3_4_num = 0;
        p3_5_num = 0;

        p4_1_num = 0;
        p4_2_num = 0;
        p4_3_num = 0;
        p4_4_num = 0;
        p4_5_num = 0;

        p1_total_num = 0;
        p2_total_num = 0;
        p3_total_num = 0;
        p4_total_num = 0;

    }

    public void changeNum(int player)
    {
        int playerNo = player / 100;
        int itemNo = (player / 10) % 10;
        int efect = player % 10;

        Debug.Log(playerNo);
        Debug.Log(itemNo);
        Debug.Log(efect);


        switch (playerNo)
        {

            case 1:
                switch (itemNo)
                {

                    case 1:

                        if (efect == 1)
                        {
                            p1_1_num++;
                        }
                        else
                        {
                            p1_1_num--;
                        }

                        break;

                    case 2:

                        if (efect == 1)
                        {
                            p1_2_num++;
                        }
                        else
                        {
                            p1_2_num--;
                        }

                        break;

                    case 3:

                        if (efect == 1)
                        {
                            p1_3_num++;
                        }
                        else
                        {
                            p1_3_num--;
                        }

                        break;

                    case 4:

                        if (efect == 1)
                        {
                            p1_4_num++;
                        }
                        else
                        {
                            p1_4_num--;
                        }

                        break;

                    case 5:

                        if (efect == 1)
                        {
                            p1_5_num++;
                        }
                        else
                        {
                            p1_5_num--;
                        }

                        break;

                }
                break;

            case 2:
                switch (itemNo)
                {

                    case 1:

                        if (efect == 1)
                        {
                            p2_1_num++;
                        }
                        else
                        {
                            p2_1_num--;
                        }

                        break;

                    case 2:

                        if (efect == 1)
                        {
                            p2_2_num++;
                        }
                        else
                        {
                            p2_2_num--;
                        }

                        break;

                    case 3:

                        if (efect == 1)
                        {
                            p2_3_num++;
                        }
                        else
                        {
                            p2_3_num--;
                        }

                        break;

                    case 4:

                        if (efect == 1)
                        {
                            p2_4_num++;
                        }
                        else
                        {
                            p2_4_num--;
                        }

                        break;

                    case 5:

                        if (efect == 1)
                        {
                            p2_5_num++;
                        }
                        else
                        {
                            p2_5_num--;
                        }

                        break;

                }
                break;

            case 3:
                switch (itemNo)
                {

                    case 1:

                        if (efect == 1)
                        {
                            p3_1_num++;
                        }
                        else
                        {
                            p3_1_num--;
                        }

                        break;

                    case 2:

                        if (efect == 1)
                        {
                            p3_2_num++;
                        }
                        else
                        {
                            p3_2_num--;
                        }

                        break;

                    case 3:

                        if (efect == 1)
                        {
                            p3_3_num++;
                        }
                        else
                        {
                            p3_3_num--;
                        }

                        break;

                    case 4:

                        if (efect == 1)
                        {
                            p3_4_num++;
                        }
                        else
                        {
                            p3_4_num--;
                        }

                        break;

                    case 5:

                        if (efect == 1)
                        {
                            p3_5_num++;
                        }
                        else
                        {
                            p3_5_num--;
                        }

                        break;

                }
                break;

            case 4:
                switch (itemNo)
                {

                    case 1:

                        if (efect == 1)
                        {
                            p4_1_num++;
                        }
                        else
                        {
                            p4_1_num--;
                        }

                        break;

                    case 2:

                        if (efect == 1)
                        {
                            p4_2_num++;
                        }
                        else
                        {
                            p4_2_num--;
                        }

                        break;

                    case 3:

                        if (efect == 1)
                        {
                            p4_3_num++;
                        }
                        else
                        {
                            p4_3_num--;
                        }

                        break;

                    case 4:

                        if (efect == 1)
                        {
                            p4_4_num++;
                        }
                        else
                        {
                            p4_4_num--;
                        }

                        break;

                    case 5:

                        if (efect == 1)
                        {
                            p4_5_num++;
                        }
                        else
                        {
                            p4_5_num--;
                        }

                        break;

                }
                break;

        }


        updateNumbers();
    }

    public void openCloseEdit()
    {
        if (!edit)
        {
            foreach (var item in changeButtons)
            {
                item.SetActive(true);
            }
            foreach (var item in yolButtons)
            {
                item.SetActive(true);
            }
            foreach (var item in orduButtons)
            {
                item.SetActive(true);
            }

            edit = true;
        }
        else
        {
            foreach (var item in changeButtons)
            {
                item.SetActive(false);
            }
            foreach (var item in yolButtons)
            {
                item.SetActive(false);
            }
            foreach (var item in orduButtons)
            {
                item.SetActive(false);
            }
            edit = false;
        }

    }


    public void pickYol(int no)
    {
        switch (no)
        {
            case 1:
                p1_3_num = 2;
                p2_3_num = 0;
                p3_3_num = 0;
                p4_3_num = 0;

                yolButtons[0].GetComponent<Image>().color = new Color32(141, 249, 255, 255);
                yolButtons[1].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[2].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[3].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                break;

            case 2:
                p1_3_num = 0;
                p2_3_num = 2;
                p3_3_num = 0;
                p4_3_num = 0;

                yolButtons[0].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[1].GetComponent<Image>().color = new Color32(141, 249, 255, 255);
                yolButtons[2].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[3].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                break;

            case 3:
                p1_3_num = 0;
                p2_3_num = 0;
                p3_3_num = 2;
                p4_3_num = 0;

                yolButtons[0].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[1].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[2].GetComponent<Image>().color = new Color32(141, 249, 255, 255);
                yolButtons[3].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                break;

            case 4:
                p1_3_num = 0;
                p2_3_num = 0;
                p3_3_num = 0;
                p4_3_num = 2;

                yolButtons[0].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[1].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[2].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                yolButtons[3].GetComponent<Image>().color = new Color32(141, 249, 255, 255);
                break;
        }

        updateNumbers();
    }

    public void pickOrdu(int no)
    {
        switch (no)
        {
            case 1:
                p1_4_num = 2;
                p2_4_num = 0;
                p3_4_num = 0;
                p4_4_num = 0;

                orduButtons[0].GetComponent<Image>().color = new Color32(141, 249, 255, 255);
                orduButtons[1].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[2].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[3].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                break;

            case 2:
                p1_4_num = 0;
                p2_4_num = 2;
                p3_4_num = 0;
                p4_4_num = 0;

                orduButtons[0].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[1].GetComponent<Image>().color = new Color32(141, 249, 255, 255);
                orduButtons[2].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[3].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                break;

            case 3:
                p1_4_num = 0;
                p2_4_num = 0;
                p3_4_num = 2;
                p4_4_num = 0;

                orduButtons[0].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[1].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[2].GetComponent<Image>().color = new Color32(141, 249, 255, 255);
                orduButtons[3].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                break;

            case 4:
                p1_4_num = 0;
                p2_4_num = 0;
                p3_4_num = 0;
                p4_4_num = 2;

                orduButtons[0].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[1].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[2].GetComponent<Image>().color = new Color32(77, 77, 77, 255);
                orduButtons[3].GetComponent<Image>().color = new Color32(141, 249, 255, 255);
                break;
        }

        updateNumbers();
    }
    

}
