namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        // Gets an enumerable list of all pies.
        IEnumerable<Pie> AllPies { get; }

        // Gets an enumerable list of pies that are considered "Pies of the week".
        IEnumerable<Pie> PiesOfTheWeek { get; }

        // Gets a pie by its unique identifier (nullable).
        Pie? GetPieById(int pieId);
    }
}
