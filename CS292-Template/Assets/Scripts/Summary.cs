using UnityEngine;
using UnityEngine.UI;

public class Summary : MonoBehaviour
{
    // Start is called before the first frame update

    public Text chip;
    public Text coffee;
    public Text soda;
    public Text cookie;
    public Text eggs;
    public Text noodle;
    public Text popsicle;
    public Text sandwich;
    void Start()
    {

    }

    public void setSumm()
    {
        chip.text = Blade.chip.ToString();
        coffee.text = Blade.coffee.ToString();
        soda.text = Blade.soda.ToString();
        cookie.text = Blade.candy.ToString();
        eggs.text = Blade.eggs.ToString();
        noodle.text = Blade.noodle.ToString();
        popsicle.text = Blade.popsicle.ToString();
        sandwich.text = Blade.sandwich.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //setSumm();
    }
}
