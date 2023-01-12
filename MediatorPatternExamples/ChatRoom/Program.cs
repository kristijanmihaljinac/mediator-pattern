// Create a new chat room
using ChatRoom;

IChatRoom chatRoom = new ChatRoom.ChatRoom();
// Create new users and register them in the chat room
User alice = new User("Alice", chatRoom);
User bob = new User("Bob", chatRoom);

// Alice sends a message to Bob
alice.Send("Bob", "Hello Bob!");

// Bob sends a message to Alice
bob.Send("Alice", "Hello Alice!");

Console.ReadKey();
