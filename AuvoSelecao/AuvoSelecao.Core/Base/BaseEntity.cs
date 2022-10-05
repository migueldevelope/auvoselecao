using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuvoSelecao.Core.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
    }
}
