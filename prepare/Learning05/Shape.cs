public class Shape
{
    private string _color;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string newColor)
    {
        _color = newColor;
    }

    public virtual double GetArea()
    {
        return 0;
    }


    
}