using System.Text.Json;
// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();
Console.WriteLine("\x1b[3J");

// display first character
// Console.WriteLine(characters.First().Display());

// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }

// display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");

// how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");

// which characters were created in 1995
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//   Console.WriteLine(characterDTO.Display());
// }

// how many characters in total (all series)?
// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");

// how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {MarioCount} characters in the Mario series");

// how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");

// how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");

// which characters (name only) appear in Mario and Donkey Kong?
// foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");

// which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }

// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");

// which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
// foreach (var characterByYearCreated in CharactersByYearCreated)
// {
//     Console.WriteLine(characterByYearCreated.Key);
//     foreach (var character in characterByYearCreated)
//     {
//         Console.WriteLine($"\t{character.Name}");
//     }
// }

// // [1.19a] How many character(s) were created in 1981 (all series)?
// Console.WriteLine(characters.Count(c => c.YearCreated == 1981));
// // [1.19b] List the character(s) created in that 1981 (all series) - return character name and series only.
// foreach (var obj in characters.Where(c => c.YearCreated == 1981).Select(c => new {c.Name, c.Series})) Console.WriteLine($"{obj.Name} - {String.Join(", ", obj.Series.ToArray())}");
// // [1.19c] How many character(s) were created in 1981 (Mario series)?
// Console.WriteLine(characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Mario")));
// // [1.19d] List the character(s) created in that 1981 (Mario series) - return character name only.
// foreach (string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Select(c => c.Name)) Console.WriteLine(name);
// // [1.19e] How many character(s) were created in 1981 (Donkey Kong series)?
// Console.WriteLine(characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")));
// // [1.19f] List the character(s) created in that 1981 (Donkey Kong series) - return character name only.
// foreach (string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Select(c => c.Name)) Console.WriteLine(name);
// [1.20a] How many character(s) made their first appearance in Donkey Kong 64?
Console.WriteLine(characters.Count(c => c.FirstAppearance == "Donkey Kong 64"));
// [1.20b] List the character(s) that made their first appearance in Donkey Kong 64 - return character name only.
foreach(string n in characters.Where(c => c.FirstAppearance == "Donkey Kong 64").Select(c => c.Name)) Console.WriteLine(n);
// [1.21a] Are there any character(s) with no alias (all series)?
Console.WriteLine(characters.Any(c => c.Alias.Count() == 0));
// [1.21b] How many character(s) with no alias (all series)?
Console.WriteLine(characters.Count(c => c.Alias.Count() == 0));
// [1.21c] List the character(s) with no alias (all series) - return character name, alias and series only.
foreach(var obj in characters.Where(c => c.Alias.Count() == 0).Select(c => new {c.Name, c.Series})) Console.WriteLine($"{obj.Name} - {String.Join(", ", obj.Series.ToArray())}");
// [1.21d] Are there any character(s) with no alias (Mario series)?
// [1.21e] How many character(s) with no alias (Mario series)?
// [1.21f] List the character(s) with no alias (Mario series) - return character name and alias only.
// [1.21g] Are there any character(s) with no alias (Donkey Kong series)?
// [1.21h] How many character(s) with no alias (Donkey Kong series)?
// [1.21i] List the character(s) with no alias (Donkey Kong series) - return character name and alias only.
// [1.22a] Do any character(s) have an alias of Snowmad King (return type must be boolean)?
// [1.22b] List the character(s) that have an alias of Snowmad King - return character name and alias only.
// [1.23a] Do any character(s) that have an alias of Winter Kong (return type must be boolean)?
// [1.23b] List the character(s) that have an alias of Winter Kong - return character name and alias only.
// [1.24a] How many character(s) have a species of Kremling?
// [1.24b] List the character(s) that have a species of Kremling - return character name only.
// [1.25a] How many character(s) in the Mario series are Human species?
// [1.25b] List the character(s) in the Mario series that are Human species - return character name only.
// [1.25c] How many character(s) in the Mario series are Koopa species?
// [1.25d] List the character(s) in the Mario series that are Koopa species - return character name only.
// [1.25e] How many character(s) in the Mario series are something other than Human or Koopa species?
// [1.25f] List the character(s) in the Mario series that are something other than Human or Koopa species - return character name and species only.
// [1.26] List the character(s) in the Donkey Kong series that are something other than Human or Kong species - return character name and species only?