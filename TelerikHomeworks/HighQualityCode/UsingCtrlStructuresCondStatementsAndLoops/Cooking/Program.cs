using System;

public class Chef
{
    private Bowl GetBowl()
    {   
        //... 
    }

    private Carrot GetCarrot()
    {
        //...
    }

    private Potato GetPotato()
    {
        //...
    }

    private void Cut(Product product)
    {
        //...
    }

    private void Peel(Product product)
    {
        //...
    }

    public void Cook()
    {
        Potato potato = GetPotato();
        Peel(potato);
        Cut(potato);

        Carrot carrot = GetCarrot();
        Peel(carrot);
        Cut(carrot);

        Bowl bowl = GetBowl();
        bowl.Add(carrot);        
        bowl.Add(potato);
    }
}
