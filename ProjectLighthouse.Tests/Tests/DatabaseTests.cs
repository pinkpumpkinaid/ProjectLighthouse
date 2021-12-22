using System;
using System.Threading.Tasks;
using LBPUnion.ProjectLighthouse.Helpers;
using LBPUnion.ProjectLighthouse.Types;

namespace LBPUnion.ProjectLighthouse.Tests
{
    public class DatabaseTests : LighthouseTest
    {
        [DatabaseFact]
        public async Task CanCreateUserTwice()
        {
            await using Database database = new();
            int rand = new Random().Next();

            User userA = await database.CreateUser("createUserTwiceTest" + rand, HashHelper.GenerateAuthToken());
            User userB = await database.CreateUser("createUserTwiceTest" + rand, HashHelper.GenerateAuthToken());

            await database.RemoveUser(userA);
            await database.RemoveUser(userB);

            await database.SaveChangesAsync();
        }
    }
}