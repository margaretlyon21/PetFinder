namespace PetFinder.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Size { get; set; }

        public Pet()
        {
            
        }

    }
}
