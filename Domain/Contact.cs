using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Contact : SeedWork.Entity
{

    #region Constructor
  
    public Contact()
    {
        
    }

    #endregion /Constructor

    #region 

    [MaxLength(20)]
    public string? Name { get; set; }
   
    [MaxLength(60)]
    [DisplayName ("Last Name")]
    public string? LastName { get; set; }

    public string? Organization { get; set; }

    [MaxLength(60)]
    public string? Position { get; set; }

    [MaxLength(20)]
    [MinLength(3)]
    [Browsable(false)]
    [DisplayName("Office Phone Number")]
    public string? OfficePhone { get; set; }

    [MaxLength(50)]
    [MinLength(10)]
    //[RegularExpression("^\d{11}")]
    [Browsable (false)]
    [DisplayName("Mobile Number 1")]
    public string? MobilePhone1 { get; set; }


    [MaxLength(50)]
    //[RegularExpression("^\d{11}")]
    [Browsable(false)]
    [DisplayName("Mobile Number 2")]
    public string? MobilePhone2 { get; set; }

    
    #endregion /

}

