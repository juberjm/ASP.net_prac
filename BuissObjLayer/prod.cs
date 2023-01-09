namespace BuissObjLayer;

public class prod{

public int id{get;set;}

public string title{get;set;}

public string category{get;set;}

public string description{get;set;}

public float unitPrice{get;set;}

public int balance{get;set;}


public prod() { }

public prod(int id, string title, string category, string description, float unitPrice, int balance)
{
    this.id = id;
    this.title = title;
    this.category = category;
    this.description = description;
    this.unitPrice = unitPrice;
    this.balance = balance;
}
}
