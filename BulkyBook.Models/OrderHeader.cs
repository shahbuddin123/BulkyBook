using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BulkyBook.Models
{
    public class OrderHeader
    {
        [Key]

        public int Id { get; set; }

        

        

        [Required]

        public DateTime OrderDate { get; set; }
        [Required]

        public DateTime ShippingDate { get; set; }

        public double OrderTotal { get; set; }

        public int TrackingNumber { get; set; }

        public int Carrier { get; set; }

        public int OrderStatus { get; set; }

        public int PaymentStatus { get; set; }

        public DateTime PaymentDate { get; set; }

        public DateTime PaymentDueDate { get; set; }

        public string TransactionId { get; set; }

        public string PhoneNumber { get; set; }

        public string StreetAdress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Name { get; set; }



    }
}
