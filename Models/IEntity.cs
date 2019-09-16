using RepositoryHelpers;

namespace repohelp.Models
{
    public interface IEntity
    {
        [PrimaryKey]
        int Id { get; set; }
    }
}