namespace ParcelShipping.Objects
{
  public class ParcelPrice
  {

    private int _length;
    private int _width;
    private int _weight;
    private int _smallPackageRate = 1;
    private int _largePackageRate = 2;
    private int _smallPackageMax = 5;

    public ParcelPrice(int length, int width, int weight)
    {
      _length = length;
      _width = width;
      _weight = weight;
    }

    public int Volume ()
    {
      return _length * _width;
    }

    public bool IsSmallPackage()
    {
      if (Volume() < _smallPackageMax){
        return true;
      }else{
        return false;
      }
    }

    public int CostToShip()
    {
      if (IsSmallPackage()) {
        return _smallPackageRate * _weight;
      }else{
        return _largePackageRate * _weight;
      }
    }





    // private int _length;
    // public int GetLength()
    // {
    //   return _length;
    // }
    // public void SetLength(int newLength)
    // {
    //   _length = newLength;
    // }
    //
    // private int _width;
    // public int GetWidth()
    // {
    //   return _width;
    // }
    // public void SetWidth(int newWidth)
    // {
    //   _width = newWidth;
    // }
    //
    // private int _weight;
    // public int GetWeight()
    // {
    //   return _weight;
    // }
    // public void SetWeight(int newWeight)
    // {
    //   _weight = newWeight;
    // }





  }
}
