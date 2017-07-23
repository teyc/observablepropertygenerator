# Documentation

An example usage. You type this in your main code file:

```
public partial class MyViewModel
{
  [GenerateObservableProperty]
  private string _customerName
}

```

When you click save, Visual Studio 2010 will create a sub-file with the following code:

```
public partial class MyViewModel
{
  public string CustomerName
  {
    get
    {
       return _customerName;
    }
    set
    {
      if(_customerName != value)
      {
         _customerName = value;
         RaisePropertyChanged(MyViewModelProperties.CustomerName);
      }
    }
   }
  public partial class MyViewModelProperties
  {
    public const string CustomerName = "CustomerName";
  }
}
```
