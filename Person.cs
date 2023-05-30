﻿namespace Packt.shared;

public class Person : Object{
  //properties
  public string? Name { get; set; }
  public DateTime DateOfBirth { get; set; }

  //methods
  public void WriteToConsole(){
    WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
  }
}