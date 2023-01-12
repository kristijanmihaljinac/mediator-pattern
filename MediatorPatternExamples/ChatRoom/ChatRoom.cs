namespace ChatRoom;

class ChatRoom : IChatRoom
{
    // Dictionary to store users in the chat room
    private Dictionary<string, User> users = new Dictionary<string, User>();

    // Register a user in the chat room
    public void Register(User user)
    {
        if (users.ContainsKey(user.Name))
        {
            throw new Exception("Already have user with same username");
        }

        users.Add(user.Name, user);
    }

    // Send a message from one user to another
    public void Send(string from, string to, string message)
    {
        User user = users[to];
        user.Receive(from, message);
    }
}

