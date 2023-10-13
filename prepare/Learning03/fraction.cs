public class Fraction
{
    private int _top;
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    

    private int _bottom;
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    

    public Fraction()
    {
        this._top = 1;
        this._bottom = 1;
    }
    public Fraction(int top)
    {
        this._top = top;
        this._bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{this._top}/{this._bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}