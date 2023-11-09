using System.ComponentModel.DataAnnotations;
namespace LibraryWebApp.Models
{
    public class bookType
    {
        [Key] //Id alanı primary key olacak(database)
        public int Id { get; set; }
        //Eger [Key] tanimlamasi yapilmasa bile primary key(Id/(KitapTuruId de olabilir) olarak degiskeni belirtince) default olarak algılanıyor 


        [Required] //Kitap türü null olmamalı(not null)
        public string Name { get; set; }

    }
}
