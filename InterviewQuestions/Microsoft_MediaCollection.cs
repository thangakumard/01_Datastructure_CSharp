
namespace InterviewQuestions
{
    [TestClass]
    public class Microsoft_MediaCollection
    {
        // Main Program for testing
        [TestMethod]
        public void Test()
        {
            Library library = new Library();
            
            // Add Media Items
            library.AddMedia(new Video { Id = 1, Title = "Star Wars", Director = "George Lucas", ReleaseDate = new DateTime(1977, 5, 25) });
            library.AddMedia(new Video { Id = 2, Title = "Inception", Director = "Christopher Nolan", ReleaseDate = new DateTime(2010, 7, 16) });
            library.AddMedia(new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" });
            library.AddMedia(new Song { Id = 4, Title = "Bohemian Rhapsody", Singer = "Freddie Mercury", Composer = "Freddie Mercury", ReleaseDate = new DateTime(1975, 10, 31) });

            // Test Get by ID and Priority Increase
            var video = library.GetMediaById(1);
            Console.WriteLine($"Retrieved: {video?.Title}, Priority: {video?.Priority}");

            // Test Update
            library.UpdateMedia(new Video { Id = 1, Title = "Star Wars - Updated", Director = "George Lucas", ReleaseDate = new DateTime(1977, 5, 25) });
            Console.WriteLine($"Updated Title: {library.GetMediaById(1)?.Title}");

            // Test Retrieve Top Priority Videos by Year
            var topVideos = library.GetTopPriorityVideosByYear(1977);
            Console.WriteLine("Top Priority Videos Released in 1977:");
            foreach (var v in topVideos)
            {
                Console.WriteLine($"{v.Title} - Priority: {v.Priority}");
            }

            // Test Search by Title
            var searchResults = library.SearchByTitle("Star");
            Console.WriteLine("Search Results for 'Star':");
            foreach (var m in searchResults)
            {
                Console.WriteLine($"{m.Title} - Priority: {m.Priority}");
            }
    }
        // Define Base Media Class
        public abstract class Media
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Priority { get; set; } = 0;  // Priority for recently viewed items
        }

        // Video Class
        public class Video : Media
        {
            public string Director { get; set; }
            public DateTime ReleaseDate { get; set; }
        }

        // Book Class
        public class Book : Media
        {
            public string Author { get; set; }
        }

        // Song Class
        public class Song : Media
        {
            public string Singer { get; set; }
            public string Composer { get; set; }
            public DateTime ReleaseDate { get; set; }
        }

        // Library Class
        public class Library
        {
            private readonly List<Media> mediaCollection = new List<Media>();

            // CRUD Operations

            // Create
            public void AddMedia(Media media)
            {
                mediaCollection.Add(media);
            }

            // Read
            public Media GetMediaById(int id)
            {
                var media = mediaCollection.FirstOrDefault(m => m.Id == id);
                if (media != null)
                {
                    media.Priority += 1;  // Increase priority when accessed
                }
                return media;
            }

            // Update
            public bool UpdateMedia(Media updatedMedia)
            {
                var existingMedia = GetMediaById(updatedMedia.Id);
                if (existingMedia != null)
                {
                    existingMedia.Title = updatedMedia.Title;
                    existingMedia.Priority += 1;

                    // Update specific properties based on media type
                    if (existingMedia is Video video && updatedMedia is Video updatedVideo)
                    {
                        video.Director = updatedVideo.Director;
                        video.ReleaseDate = updatedVideo.ReleaseDate;
                    }
                    else if (existingMedia is Book book && updatedMedia is Book updatedBook)
                    {
                        book.Author = updatedBook.Author;
                    }
                    else if (existingMedia is Song song && updatedMedia is Song updatedSong)
                    {
                        song.Singer = updatedSong.Singer;
                        song.Composer = updatedSong.Composer;
                        song.ReleaseDate = updatedSong.ReleaseDate;
                    }

                    return true;
                }
                return false;
            }

            // Delete
            public bool DeleteMediaById(int id)
            {
                var media = GetMediaById(id);
                if (media != null)
                {
                    mediaCollection.Remove(media);
                    return true;
                }
                return false;
            }

            // Retrieve top-priority videos by year
            public List<Video> GetTopPriorityVideosByYear(int year)
            {
                return mediaCollection
                    .OfType<Video>()
                    .Where(v => v.ReleaseDate.Year == year)
                    .OrderByDescending(v => v.Priority)
                    .ToList();
            }

            // Search by title (case-insensitive)
            public List<Media> SearchByTitle(string titleFragment)
            {
                return mediaCollection
                    .Where(m => m.Title != null && m.Title.IndexOf(titleFragment, StringComparison.OrdinalIgnoreCase) >= 0)
                    .OrderByDescending(m => m.Priority)
                    .ToList();
            }
        }


    }
}
