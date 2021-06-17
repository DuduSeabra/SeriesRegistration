namespace SeriesRegistration
{
    public class Serie : BaseEntity
    {
        //Atributes
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Deleted { get; set; }

        public Serie(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public override string ToString()
        {
            string text = null;
            text += "Genre: " + this.Genre + "\n";
            text += "Title: " + this.Title + "\n";
            text += "Description: " + this.Description + "\n";
            text += "Year: " + this.Year + "\n";
            text += "Deleted: " + this.Deleted + "\n";

            return text;
        }

        public string returnTitle()
        {
            return this.Title;
        }
        public int returnId()
        {
            return this.Id;
        }
        public bool returnDeleted()
        {
            return this.Deleted;
        }
        public void Delete()
        {
            this.Deleted = true;
        }
    }
}