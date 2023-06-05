﻿namespace TodoList.Models;

class TodoModel
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public bool Completed { get; set; } = false;
}
