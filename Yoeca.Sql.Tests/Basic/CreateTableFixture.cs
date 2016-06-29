﻿using NUnit.Framework;
using Yoeca.Sql.NUnit;

namespace Yoeca.Sql.Tests.Basic
{
    [TestFixture]
    internal sealed class CreateTableFixture
    {
        [Test]
        public void SupportForBasicTypes()
        {
            const string expected = @"CREATE TABLE Extended(
Identifier CHAR(32) NOT NULL, Name VARCHAR(128) NOT NULL, Age INT, Payload BLOB NOT NULL,
PRIMARY KEY (Identifier)
)";
            string command = CreateTable.For<ExtendedTable>().Format(SqlFormat.MySql);

            Assert.That(command, Is.EqualTo(expected));
        }

        [Test]
        public void SupportForSimpleType()
        {
            const string expected = @"CREATE TABLE Simple(
Name TEXT
)";
            string command = CreateTable.For<SimpleTable>().Format(SqlFormat.MySql);

            Assert.That(command, Is.EqualTo(expected));
        }
    }
}