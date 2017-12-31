using CodeNight.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNight.DataAccessLayer
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 0; i < 20; i++)
            {
                User user = new User()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Username = $"footballer{i}",
                    Password = "123456",
                    Email = FakeData.NetworkData.GetEmail(),
                    ProfileImageFileName = "default.jpeg",
                    PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber(),
                    DateOfBirth = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-50), DateTime.Now.AddYears(-12)),
                    ActivateGuid = Guid.NewGuid(),
                    IsActive = true
                };
                context.Users.Add(user);
            }
            context.SaveChanges();


            List<User> userList = context.Users.ToList();
            for (int i = 0; i < FakeData.NumberData.GetNumber(20, 30); i++)
            {
                User owner = userList[FakeData.NumberData.GetNumber(0, userList.Count - 1)];
                Share share = new Share()
                {

                    ShareText = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1, 3)),
                    Owner = owner,
                    LikeCount = FakeData.NumberData.GetNumber(1, 15),
                    CreatedDate = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ShareImagFileName = "ay.jpg",
                };
                context.Shares.Add(share);
                for (int j = 0; j < FakeData.NumberData.GetNumber(5, 20); j++)
                {
                    User comment_owner = userList[FakeData.NumberData.GetNumber(0, userList.Count - 1)];

                    Comments comment = new Comments()
                    {
                        CommentText = FakeData.TextData.GetSentence(),
                        Owner = comment_owner,
                        CreatedDate = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),

                    };
                    share.Comments.Add(comment);

                }

                // adding fake likes
                for (int m = 0; m < share.LikeCount; m++)
                {
                    Liked liked = new Liked()
                    {
                        LikedUser = userList[m]
                    };

                    share.Likes.Add(liked);
                }
                context.SaveChanges();

            }
        }
    }
}
    
