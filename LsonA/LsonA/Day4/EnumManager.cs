/* 
important of version number in enum
*/
public enum MovieRating
{
   VeryBad = 0,
    Bad = 1, //version number for the enum Constant
    Average = 2,
    Good = 3,
    VeryGood = 4,
    Excellent = 5

}
public enum CarColor{
    Black =0,
    White =1,
    Red =2,
    Blue =3, // after the last enum constant we can use comma, the version number is always next to the enum constant by one, duplicates are allowed
}
public enum Deserts{
    Icecream,
    Cake,
    MysorePak
}