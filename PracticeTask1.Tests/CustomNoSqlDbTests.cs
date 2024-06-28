using System;
using Xunit;
using practice_task1;
using System.Linq;

public class CustomNoSqlDbTests
{
    private readonly CustomNoSqlDb _db;

    public CustomNoSqlDbTests()
    {
        _db = new CustomNoSqlDb("TestDatabase");
    }

    [Fact]
    public void CanInsertAndRetrieveDocument()
    {
        var document = new { Id = Guid.NewGuid(), Name = "John Doe", Age = 25 };
        _db.Insert(document, "people");

        var retrievedDocument = _db.GetById<dynamic>(document.Id, "people");
        Assert.NotNull(retrievedDocument);
        Assert.Equal("John Doe", (string)retrievedDocument.Name);
        Assert.Equal(25, (int)retrievedDocument.Age);
    }

    [Fact]
    public void CanUpdateDocument()
    {
        var document = new { Id = Guid.NewGuid(), Name = "Jane Doe", Age = 28 };
        _db.Insert(document, "people");

        var updatedDocument = new { Id = document.Id, Name = "Jane Smith", Age = 30 };
        _db.Update(document.Id, updatedDocument, "people");

        var retrievedDocument = _db.GetById<dynamic>(document.Id, "people");
        Assert.NotNull(retrievedDocument);
        Assert.Equal("Jane Smith", (string)retrievedDocument.Name);
        Assert.Equal(30, (int)retrievedDocument.Age);
    }

    [Fact]
    public void CanDeleteDocument()
    {
        var document = new { Id = Guid.NewGuid(), Name = "John Smith", Age = 40 };
        _db.Insert(document, "people");

        _db.Delete(document.Id, "people");

        var retrievedDocument = _db.GetById<dynamic>(document.Id, "people");
        Assert.Null(retrievedDocument);
    }


    [Fact]
    public void GetByIdReturnsNullForNonExistingDocument()
    {
        var nonExistingId = Guid.NewGuid();
        var retrievedDocument = _db.GetById<dynamic>(nonExistingId, "people");
        Assert.Null(retrievedDocument);
    }

    [Fact]
    public void InsertThrowsExceptionForDocumentWithoutId()
    {
        var document = new { Name = "No ID", Age = 20 };
        var exception = Assert.Throws<Exception>(() => _db.Insert(document, "people"));
        Assert.Equal("Document must have an Id property", exception.Message);
    }
}
