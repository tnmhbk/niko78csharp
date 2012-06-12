namespace EFComposite.Model
{
    public abstract class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Island ParentPosition { get; set; }
    }
}
