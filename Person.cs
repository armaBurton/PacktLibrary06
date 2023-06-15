namespace Packt.Shared;

public class Person : object, IComparable<Person?>{
  //properties
  public string? Name { get; set; }
  public DateTime DateOfBirth { get; set; }

  //methods
  public void WriteToConsole(){
    WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
  }

  //delegate field
  public event EventHandler? Shout;

  //data
  public int AngerLevel;

  //method
  public void Poke(){
    AngerLevel++;
    if (AngerLevel >= 3){
      //if something is listening
      if(Shout != null){
        //...then call the delegate
        Shout(this, EventArgs.Empty);
      }
    }
  }

    public int CompareTo(Person? other){
      int position;
      
      if((this is not null) && (other is not null)){
        if((Name is not null) && (other.Name is not null)){
          //if both Name values are not null
          //use the string implementation of CompareTo
          position = Name.CompareTo(other.Name);
        } else if ((Name is not null) && (other.Name is null)){
          position = -1;
        } else if ((Name is null) && (other.Name is not null)){
          position = 1;
        } else {
          position = 0;
        }
      } else if ((this is not null) && (other is null)){
        position = -1;
      } else if ((this is null) && (other is not null)){
        position = 1;
      } else {
        position = 0;
      }
      return position;
    }
}