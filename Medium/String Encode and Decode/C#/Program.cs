using String_Encode_and_Decode;

var task = new Solution();
string encode = task.Encode(["","   ","!@#$%^&*()_+","LongStringWithNoSpaces","Another, String With, Commas"]);
var decode = task.Decode(encode);

Console.WriteLine(encode);
Console.WriteLine("\n-" + string.Join("\n- ",decode));
