# InventoryProject2021
This is a prototype inventory program with a rudimentary feature set. It is a project for WGU - Software Development - Software I – C# – C968.

The classes are based on strict structure requirements, certain parts of which I disagree with. I would have made both Parts and Products inherit from a parent abstract class "Item". This would vastly improve readability and overall program structure; as it is, there are confusing elements around both primary lists of Parts and Products. Both Parts and Products are actually Product types, because the abstract Part class is unable to have instance variables. This makes no sense to me, but it was a hard requirement.
