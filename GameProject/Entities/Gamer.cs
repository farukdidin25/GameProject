﻿// See https://aka.ms/new-console-template for more information
using GameProject.Abstract;

public class Gamer : IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string NationalityId { get; set; }
}