using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private int _phone;
    private string _address;
    private int _id;

    private static List<Contact> _allcontacts = new List<Contact>{};

    public Contact(string name, int phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _allcontacts.Add(this);
      _id = _allcontacts.Count;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetPhone(int newPhone)
    {
      _phone = newPhone;
    }
    public int GetPhone()
    {
      return _phone;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public string GetAddress()
    {
      return _address;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _allcontacts;
    }
    public static List<Contact> ViewAllContacts()
    {
      return _allcontacts;
    }
    public static void ClearAllContacts()
    {
      _allcontacts.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _allcontacts[searchId - 1];
    }
  }
}
