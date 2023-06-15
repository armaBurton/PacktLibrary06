namespace Packt.Shared;

public class PersonComparer : IComparer<Person?>{
    public int Compare(Person? x, Person? y){
        int position;
        if((x is not null) && (y is not null)){
          if((x is not null) && (y is not null)){
            //both values are not null

            //...compare the Name Lengths...
            int result = x.Name.Length.CompareTo(y.Name.Length);
            
            //...if they are equal...
            if(result == 0){
              //...then compare by the Names
              return x.Name.CompareTo(y.Name);
            } else {
              position = result;
            }
          } else if ((x.Name is not null) && (y.Name is null)){
            position = -1; //else x Person precedes y Person
          }  else if ((x is null) && (y is not null)){
            position = 1;
          } else {
            position = 0;  //x Person and y Person are at the same position
          }
          return position;
        }
    }
}