namespace ChatRoom;

class User
{
    public string Name { get; set; }
    public IChatRoom ChatRoom { get; set; }

    // constructor to register user in the chat room
    public User(string name, IChatRoom chatRoom)
    {
        Name = name;
        ChatRoom = chatRoom;
        ChatRoom.Register(this);
    }

    // Send a message to another user
    public void Send(string to, string message)
    {
        ChatRoom.Send(Name, to, message);
    }

    // Receive a message from another user
    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"{from} to {Name}: {message}");
    }
}

