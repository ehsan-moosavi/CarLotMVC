using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AutoLotDAL.Models.MetaData
{
    class InventoryMetaData
    {
        [Display(Name = "Pet Name")]
        public String PetName;
        [StringLength (50,ErrorMessage ="Please Enter A valu Less Than 50 chracters Long")]
        public string Make;
    }
}
