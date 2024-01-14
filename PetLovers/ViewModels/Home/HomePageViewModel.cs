using CommunityToolkit.Mvvm.ComponentModel;
using PetLovers.Models;
using System.Collections.ObjectModel;

namespace PetLovers.ViewModels.Home
{
    public partial class HomePageViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<Story> stories = new ObservableCollection<Story>();

        [ObservableProperty]
        ObservableCollection<Category> categories = new ObservableCollection<Category>();

        [ObservableProperty]
        ObservableCollection<Post> posts = new ObservableCollection<Post>();

        private async Task GetPostsAsync()
        {
            Posts.Add(new Post
            {
                Id = 1,
                User = new User
                {
                    Id = 1, 
                    Name = "Ella",
                    Surname = "Reed",
                    ProfilePicture = ImageSource.FromUri(new Uri("https://i.pinimg.com/736x/a8/42/f0/a842f0c493c728f3ffa00bd1dad0299b.jpg"))
                },
                Category = new Category
                {
                    Id = 1,
                    Name = "Cats"
                },
                Image = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Cat_August_2010-4.jpg/1200px-Cat_August_2010-4.jpg")),
                CreatedDate = DateTimeOffset.Now.AddDays(-3),
                LovesCount = 452,
                CommentsCount = 512,
                ReSharedCount = 320,
                IsLiked = true,

            });

            Posts.Add(new Post
            {
                Id = 2,
                User = new User
                {
                    Id = 2,
                    Name = "Johnston",
                    Surname = "Smith",
                    ProfilePicture = ImageSource.FromUri(new Uri("https://vivifyintegrativehealth.com/wp-content/uploads/2017/02/44813671_m.jpg"))
                },
                Category = new Category
                {
                    Id = 2,
                    Name = "Dogs"
                },
                Image = ImageSource.FromUri(new Uri("https://hips.hearstapps.com/ghk.h-cdn.co/assets/16/08/gettyimages-530330473.jpg")),
                CreatedDate = DateTimeOffset.Now.AddMinutes(-30),
                LovesCount = 452,
                CommentsCount = 512,
                ReSharedCount = 320,
                IsLiked = false,

            });
            Posts.Add(new Post
             {
                 Id = 2,
                 User = new User
                 {
                     Id = 2,
                     Name = "Johnston",
                     Surname = "Smith",
                     ProfilePicture = ImageSource.FromUri(new Uri("https://vivifyintegrativehealth.com/wp-content/uploads/2017/02/44813671_m.jpg"))
                 },
                 Category = new Category
                 {
                     Id = 2,
                     Name = "Dogs"
                 },
                 Image = ImageSource.FromUri(new Uri("https://www.pd.com.au/wp-content/uploads/2023/01/Indian_Spitz_Dog-scaled.jpg.webp")),
                 CreatedDate = DateTimeOffset.Now.AddMinutes(-30),
                 LovesCount = 452,
                 CommentsCount = 512,
                 ReSharedCount = 320,
                 IsLiked = false,

             });
            Posts.Add(new Post
             {
                 Id = 2,
                 User = new User
                 {
                     Id = 2,
                     Name = "Johnston",
                     Surname = "Smith",
                     ProfilePicture = ImageSource.FromUri(new Uri("https://vivifyintegrativehealth.com/wp-content/uploads/2017/02/44813671_m.jpg"))
                 },
                 Category = new Category
                 {
                     Id = 1,
                     Name = "Cats"
                 },
                 Image = ImageSource.FromUri(new Uri("https://www.bluecross.org.uk/sites/default/files/d8/2020-01/Moving%20house.JPG")),
                 CreatedDate = DateTimeOffset.Now.AddMinutes(-30),
                 LovesCount = 452,
                 CommentsCount = 512,
                 ReSharedCount = 320,
                 IsLiked = false,

             });
        }
        private async Task GetCaegoriesAsync()
        {
            Categories.Add(new Category
            {
                Name = "Cats",
                Color = "#D9283A",
                Image = ImageSource.FromFile("catcatlogo.svg")
            });

            Categories.Add(new Category
            {
                Name = "Dogs",
                Color = "#28C6D9",
                Image = ImageSource.FromFile("dogcatlogo.svg")
            });
            Categories.Add(new Category
            {
                Name = "Birds",
                Color = "#28A3D9",
                Image = ImageSource.FromFile("birdcatlgoo.svg")
            });

            Categories.Add(new Category
            {
                Name = "Hamsters",
                Color = "#28D963",
                Image = ImageSource.FromFile("hamstercaticon.svg")
            });
        }
        private async Task GetStoriesAsync()
        {
            for (var i = 1; i <= 10; i++)
            {
                Stories.Add(new Story
                {
                    Id = i,
                    Text = $@"Text{i}",
                    Image = ImageSource.FromUri(new Uri("https://picsum.photos/1080/720")),
                    User = new User
                    {
                        Id = i,
                        Name = $@"Name{i}",
                        Surname = $@"Surname{i}",
                        Email = $@"test{i}@test.com",
                        ProfilePicture = ImageSource.FromUri(new Uri("https://picsum.photos/500/500"))
                    }

                });
            }
        }

        public HomePageViewModel()
        {
            GetStoriesAsync();
            GetCaegoriesAsync();
            GetPostsAsync();
        }
    }

}
