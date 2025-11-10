using System;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using P10_WebApi.Models.AbstractClasses;

namespace P10_WebApi.Models;

public class Post : BaseEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? PostId { get; set; }    // postId will used in the code as string instead of _id // objectId    
    public ObjectId? UserId { get; set; }   // userId will be saved in db and code  as object Id 
    public string? PostpicURL { get; set; }
    public string? PostVideoURL { get; set; }
    public required string PostCaption { get; set; }
    public List<ObjectId> Likes { get; set; } = [];  // likes is an array of strings  i.e userIds
    public List<Comment> Comments { get; set; } = []; 
}
