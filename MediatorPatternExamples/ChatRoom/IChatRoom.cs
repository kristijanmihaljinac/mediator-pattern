namespace ChatRoom;

interface IChatRoom
{
    // Register a user in the chat room
    void Register(User user);
    // Send a message from one user to another
    void Send(string from, string to, string message);
}

