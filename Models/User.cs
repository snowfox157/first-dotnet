using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DotnetFirst.Models;

public class User
{
    [Key]
    public int usrsid { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    [Column("create_time")]
    public DateTime CreateTime { get; set; }
    [Column("update_time")]
    public DateTime UpdateTime { get; set; }
    public required string UseNot { get; set; }
}
