using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;
[Table("PostStatus")]
public class PostStatus
{
    [Key]
    [Column("id", TypeName = "tinyint")]
    public byte Id { get; set; }
    
    [Column("name", TypeName = "nvarchar(64)")]
    public string Name { get; set; }
    
    public ICollection<Post> Posts { get; set; }
}