using System;
namespace ApexRestaurant.Repository.Domain
{
 public class Customer
 {
 public int Id { get; set; }
 public string FirstName { get; set; }
 public string LastName { get; set; }
 public string Address { get; set; }
 public string Phone { get; set; }
 public bool IsActive { get; set; }

 }
}
