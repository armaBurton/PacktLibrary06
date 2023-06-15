﻿namespace Packt.Shared;

public class Person : object{
  //properties
  public string? Name { get; set; }
  public DateTime DateOfBirth { get; set; }

  //methods
  public void WriteToConsole(){
    WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
  }

  //delegate field
  public EventHandler? Shout;

  //data
  public int AngerLevel;

  //method
  public void poke(){
    AngerLevel++;
    if (AngerLevel >= 3){
      //if something is listening
      if(Shout != null){
        //...then call the delegate
        Shout(this, EventArgs.Empty);
      }
    }
  }
}