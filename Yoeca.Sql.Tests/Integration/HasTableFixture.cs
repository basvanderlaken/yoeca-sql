using NUnit.Framework;

namespace Yoeca.Sql.Tests.Integration
{
    [TestFixture]
    internal sealed class HasTableFixture : SqlBaseFixture
    {
        [Test]
        public void VerifyHasTableWorks()
        {
            DropTable.For<Player>().TryExecute(Connection);
            Assert.That(HasTable.For<Player>().ExecuteCheck(Connection), Is.False);
            CreateTable.For<Player>().Execute(Connection);
            Assert.That(HasTable.For<Player>().ExecuteCheck(Connection), Is.True);
        }
    }
}