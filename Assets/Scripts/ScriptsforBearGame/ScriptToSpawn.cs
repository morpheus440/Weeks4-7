using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScriptToSpawn : MonoBehaviour
{
    public GameObject spawnBearPart;
    public BearPart bearPartScript;
    public GameObject destroyThis;
    float xCordinate = - 1.5f;
    float colour = 1;
    float size = 2;
    float timer;
    float speed = 2f;
    float counter = 0;

    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    
    void Start()
    {

        text2.text = "Build a bear by following the instructions and adjusting the sliders to fit the bear part. You have 10 seconds to build each part, so be quick!";
        text.text = "Left ear";
        spawnBearPartMethod();
    }
    
    void Update()
    {
        timer += Time.deltaTime;  //timer to keep track of how long the player has been building the current bear part

        if (timer >= 30f)
        {
            Destroy(destroyThis.gameObject);//destroys the current bear part
            text2.text = "you ran out of time, you made a usless chud bear :(";
        }
        switch (counter)
        {
            case 0:
                text.text = "Left ear";
                break;
            case 1:
                text.text = "Left ear"; 
                break;
            case 2:
                text.text = "Left Hand";
                break;
            case 3:
                text.text = "Right Hand";
                break;
            case 4:
                text.text = "Right Ear";
                break;
            case 5:
                text.text = "Left Foot";
                break;
            case 6:
                text.text = "Right Foot";
                break;
            case 7:
                text.text = "Head";
                break;
            case 8:
                text.text = "Body";
                break;
            case 9:
                text.text = "Left ear";
                break;
            case 10:
                text.text = "Left hand";
                break;
            case 11:
                text.text = "Right Hand";
                break;
            case 12:
                text.text = "Right Ear";
                break;
            case 13:
                text.text = "Left foot";
                break;
            case 14:
                text.text = "Right Foot";
                break;
            case 15:
                text.text = "Head";
                break;
            case 16:
                text.text = "body";
                break;
            case 17:
                text.text = "Left eye";
                break;
            case 18:
                text.text = "ALL DONE";
                transform.Rotate(0, 0, speed * Time.deltaTime);
                break;
        }
    }

    public void setTransform(float temp)//sets the transform value of the bear part
    {
        bearPartScript.setTransform(temp);
    }

    public void spawnBearPartMethod()
    {
        if(counter>= 18)
        {
            text2.text = "You built a bear! Congrats! You can keep it as a pet or you can destroy it and start again.";
            return;
        }
        partOrder();
        Vector3 spawnPosition = new Vector3(xCordinate, 1, 0);
        GameObject newBearPart = Instantiate(spawnBearPart, spawnPosition, Quaternion.identity);// makes new prefab for bear part
        bearPartScript = newBearPart.GetComponent<BearPart>();
        bearPartScript.SetColor(colour, newBearPart);//set color of bear part
        bearPartScript.SetSize(size, newBearPart);//set size of bear part
        if (timer >= 6f && timer <= 7f)//unlucky people dont get to build a bear
        {
            Destroy(newBearPart, 5f);//destroys the current bear part
        }
        timer = 0f;
        counter++;
    }

    public void partOrder()
    {
        if (counter == 0 || counter == 1)//left ear && left hand
        {
            xCordinate = -1.5f;
            colour = 1;
            size = 2; 
        }
        if (counter == 3 || counter == 2)//right ear && right hand
        {
            xCordinate = 1.5f;
            colour = 1;
            size = 2;
        }
        if (counter == 4)//left foot
        {
            xCordinate = -1.5f;
            colour = 1;
            size = 4;
        }
        if (counter == 5)//right foot
        {
            xCordinate = 1.5f;
            colour = 1;
            size = 4;
        }
        if (counter == 6)//head
        {
            xCordinate = 0f;
            colour = 1;
            size = 5;
        }
        if (counter == 7)//body
        {
            xCordinate = 0f;
            colour = 1;
            size = 6;
        }
        if (counter == 8 || counter == 9)//left ear && left hand
        {
            xCordinate = -1.5f;
            colour = 2;
            size = 1;
        }
        if (counter == 10 || counter == 11)//right ear && right hand
        {
            xCordinate = 1.5f;
            colour = 2;
            size = 1;
        }
        if (counter == 12)//left foot
        {
            xCordinate = -1.5f;
            colour = 2;
            size = 3;
        }
        if (counter == 13)//right foot
        {
            xCordinate = 1.5f;
            colour = 2;
            size = 3;
        }
        if (counter == 14)//head
        {
            xCordinate = 0f;
            colour = 2;
            size = 7;
        }
        if (counter == 15)//body
        {
            xCordinate = 0f;
            colour = 2;
            size = 8;
        }
        if (counter == 16)//left eye
        {
            xCordinate = -0.5f;
            colour = 3;
            size = 9;
        }
        if (counter == 17)//right eye
        {
            xCordinate = 0.5f;
            colour = 3;
            size = 9;
        }
    }

}
