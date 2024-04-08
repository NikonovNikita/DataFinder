using DataFinder.BLL;

class Program
{
    static void Main(string[] args)
    {
        var fileService = new FileService();

        while (true)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("DataFinder v.1.0");
            Console.WriteLine("Отобразить все файлы --> 1");
            Console.WriteLine("Выполнить поиск файла по имени --> 2");

            string input = Console.ReadLine();

            if(input == "1")
            {
                fileService.GetAllFiles().ToList().ForEach(file =>
                Console.WriteLine($"Идентификатор: {file.Id}\nИмя файла: {file.Name}\nПуть файла: {file.Path}"));
            }

            if(input == "2")
            {
                Console.WriteLine("Введите имя файла, который хотите найти");
                string fileNameInput = Console.ReadLine();

                try
                {
                    var file = fileService.GetFileByFileName(fileNameInput);
                    Console.WriteLine($"Идентификатор: {file.Id}\nИмя файла: {file.Name}\nПуть файла: {file.Path}");
                }
                catch(BusinessRuleException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}