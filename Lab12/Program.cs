using Lab12;
KVPDiskInfo diskD = new (@"D:\");
diskD.FreeSpace();
diskD.FileSystem();
KVPDiskInfo.AllInfo();

//

KVPFileInfo file1 = new(@"D:\Work\CSharpLabs\Lab12\Lab12.sln");
file1.FullPath();
file1.NameInf();
file1.Dates();

//

KVPDirInfo dir1 = new(@"D:\Work\CSharpLabs\");
dir1.NumOfFiles();
dir1.CreationTime();
dir1.SubdirLength();
dir1.Parent();

//

KVPFileManager manager = new();
manager.DirInfo(@"D:\", @"D:\Work\CSharpLabs\Lab12\kvpdirinfo.txt");

KVPFileInfo kvpdirinfo = new(@"D:\Work\CSharpLabs\Lab12\kvpdirinfo.txt");

manager.CopyAndDel(kvpdirinfo, @"D:\Work\CSharpLabs\Lab12\SomeFolder\someFile.txt");

KVPDirInfo CSharpLabs = new(@"D:\Work\CSharpLabs");

manager.CopyToKVPFiles(CSharpLabs, ".pdf");


string sourceFile = "Archieve.txt"; // исходный файл
string compressedFile = "Archieve.gz"; // сжатый файл
string targetFile = "Archieve_new.txt"; // восстановленный файл

// создание сжатого файла
await manager.CompressAsync(sourceFile, compressedFile);
// чтение из сжатого файла
await manager.DecompressAsync(compressedFile, targetFile);

