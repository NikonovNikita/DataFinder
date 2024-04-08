using DataFinder.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFinder.BLL;

public class FileService
{
    public FileRepository FileRepository { get; }

    public FileService()
    {
        FileRepository = new FileRepository();
    }

    public IEnumerable<File> GetAllFiles()
    {
        return FileRepository.GetFilesByDirectory().ToList().Select(fileEntity => new File(fileEntity));
    }

    public File GetFileByFileName(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            throw new BusinessRuleException("Введите корректное значение!");

        var fileEntity = FileRepository.GetFileByFileName(fileName);

        if (fileEntity == null)
            throw new BusinessRuleException("Файл с указанным именем не обнаружен!");

        return new File(fileEntity);
    }
}
