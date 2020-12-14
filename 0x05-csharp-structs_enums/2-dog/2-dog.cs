using System;

enum Rating
{
    Good,
    Great,
    Excellent
}
struct Dog
{   
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string nameD, float ageD, string ownerD, Rating ratingD)
    {
        name = nameD;
        age = ageD;
        owner = ownerD;
        rating = ratingD;
    }
}