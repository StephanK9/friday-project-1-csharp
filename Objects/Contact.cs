using System.Collections.Generic;

namespace AddressBook
{
  public class Contact
  {
    private string _name;
    private int _phone;
    private string _address;
    private static List<Contact> _instance = new List<Contact> {};

    public Contact(string name, int phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _instance.Add(this);
    }









  }






}
