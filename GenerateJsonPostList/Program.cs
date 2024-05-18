// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;

string postsPath = "wwwroot/posts";
var markdownFiles = Directory.EnumerateFiles(postsPath, "*.md")
    .Select(Path.GetFileName)
    .ToList();

var jsonContent = JsonConvert.SerializeObject(markdownFiles, Formatting.Indented);
File.WriteAllText(Path.Combine(postsPath, "posts.json"), jsonContent);