// See https://aka.ms/new-console-template for more information
using FSDSchoolApp;

Console.WriteLine("Hello, World!");
string path = @"c:\temp\mytest.txt";
if (!(File.Exists(path)))
{
    Console.WriteLine("Writing teacher data to file");
    FileStream fs = File.Create(path);
    using (fs)
    {
        FileManager.WriteToFile(new Teacher() { Id = 1, Name = "Jane Smith", ClassName = "Grade 2", Section = "Elementary" }, fs);
        FileManager.WriteToFile(new Teacher() { Id = 2, Name = "John Smith", ClassName = "Grade 3", Section = "Elementary" }, fs);
    }
    fs.Close();

    Console.WriteLine("Reading teacher data from file");
    FileStream fsread = File.OpenRead(path);
    FileManager.ReadFromFile(fsread);
    fsread.Close();

}




